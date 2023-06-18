#if BIE
using BepInEx.Configuration;
#endif
using System.Diagnostics;
using UnityEngine;

namespace SOTFPostProcessing.Loader.Common.Configuration;

public static class ConfigManager
{
    internal static readonly Dictionary<UniqueConfigId, IConfigElement> ConfigElements = new();

    public static ConfigHandler Handler { get; private set; }
    
    public static event Action OnConfigReloaded;

    public static bool WatchConfig
    {
        get => _fileWatcher?.Enabled ?? false;
        set
        {
            if (_fileWatcher == null)
            {
                return;
            }

            _fileWatcher.Enabled = value;
        }
    }

    private static FileWatcher _fileWatcher;

    public static void Init(ConfigHandler configHandler)
    {
        RegisterAdditionalTypes();
        
        Handler = configHandler;
        Handler.Init();

        if (UPlugin.ENABLE_CONFIG_WATCHER)
        {
            _fileWatcher = new FileWatcher(Handler.ConfigPath);
            _fileWatcher.OnFileChanged += OnFileChanged;
        }
    }

    internal static void RegisterConfigElement<T>(ConfigElement<T> configElement)
    {
        Handler.RegisterConfigElement(configElement);
        ConfigElements.Add(new UniqueConfigId(configElement.Name, configElement.Group), configElement);
    }
    
    private static void OnFileChanged()
    {
        _fileWatcher.Enabled = false;
        var sw = new Stopwatch();
        sw.Start();
        Handler.ReloadFile();
        
        OnConfigReloaded?.Invoke();
        sw.Stop();
        ULogger.Log($"Config reloaded in {sw.ElapsedMilliseconds}ms");

        _fileWatcher.Enabled = true;
    }

    private static void RegisterAdditionalTypes()
    {
        #if BIE
        TomlTypeConverter.AddConverter(typeof(Color), new TypeConverter()
        {
            ConvertToObject = (str, type) =>
            {
                if (!ColorUtility.TryParseHtmlString("#" + str, out var color))
                {
                    throw new FormatException("Invalid color format");
                }

                return color;
            },
            ConvertToString = (obj, type) => ToHtmlStringRGBA((Color) obj)
        });
        #else
        #endif
    }
    
    private static string ToHtmlStringRGBA(Color color)
    {
        Color32 color32 = new Color32((byte) Mathf.Clamp(Mathf.RoundToInt(color.r * byte.MaxValue), 0, byte.MaxValue), (byte) Mathf.Clamp(Mathf.RoundToInt(color.g * byte.MaxValue), 0, byte.MaxValue), (byte) Mathf.Clamp(Mathf.RoundToInt(color.b * byte.MaxValue), 0, byte.MaxValue), (byte) Mathf.Clamp(Mathf.RoundToInt(color.a * byte.MaxValue), 0, byte.MaxValue));
        return $"{color32.r:X2}{color32.g:X2}{color32.b:X2}{color32.a:X2}";
    }
}