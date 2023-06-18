
#if ML
using Il2CppSons.PostProcessing;
#else
using Sons.PostProcessing;
#endif

using SOTFPostProcessing.Loader.Common;
using SOTFPostProcessing.Loader.Common.Configuration;

namespace SOTFPostProcessing;

public class UPlugin : UPluginBase
{
    public readonly ILoader Loader;
    
    private PostProcessingSettings _settings;

    public UPlugin(ILoader loader)
    {
        Loader = loader;
        ULogger.Log($"Loaded {NAME} for {loader.LoaderType}");
    }

    protected override void OnInGame()
    {
        if (_settings != null)
        {
            ConfigManager.WatchConfig = false;
            _settings.SetSettings(PostProcessingManager._instance._volumeTarget.profile);
            _settings.ApplyFromConfig();
            ConfigManager.WatchConfig = true;
            ULogger.Log("Reinitialized PostProcessingSettings");
            return;
        }
        
        ConfigManager.WatchConfig = false;
        
        _settings = new PostProcessingSettings(PostProcessingManager._instance._volumeTarget.profile);
        ConfigManager.OnConfigReloaded += () =>
        {
            _settings.ApplyFromConfig();
        };
        
        ConfigManager.Handler.LoadConfig();
#if ML
        ConfigManager.Handler.SaveConfig();
#endif
        _settings.ApplyFromConfig();

        ConfigManager.WatchConfig = true;
        ULogger.Log("Initialized PostProcessingSettings");
    }

    #region CONSTS

    internal const string NAME = "SOTFPostProcessing";
    internal const string GUID = "com.tonimacaroni.sotfpostprocessing";
    internal const string VERSION = "1.0.0";
    internal const string AUTHOR = "ToniMacaroni";

    internal const int CONSOLE_R = 255;
    internal const int CONSOLE_G = 0;
    internal const int CONSOLE_B = 100;
    
    internal const bool USE_CONFIG = true;
    internal const bool ENABLE_CONFIG_WATCHER = true;
    internal const bool SUBSCRIBE_TO_SCENES = true;

    #endregion
}