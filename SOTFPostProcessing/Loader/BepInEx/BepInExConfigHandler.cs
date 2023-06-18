#if BIE
using BepInEx.Configuration;
using SOTFPostProcessing.Loader.Common;
using SOTFPostProcessing.Loader.Common.Configuration;

namespace SOTFPostProcessing.Loader.BepInEx
{
    public class BepInExConfigHandler : ConfigHandler
    {
        private const string CTG_NAME = UPlugin.NAME;

        private ConfigFile Config { get; }

        public override string ConfigPath => Config.ConfigFilePath;

        public BepInExConfigHandler(ConfigFile config)
        {
            Config = config;
        }

        public override void Init()
        {
            // Not necessary
        }

        public override void RegisterConfigElement<T>(ConfigElement<T> config)
        {
            var entry = Config.Bind(config.Group ?? CTG_NAME, config.Name, config.Value, config.Description);

            entry.SettingChanged += (o, e) => { config.Value = entry.Value; };
        }

        public override T GetConfigValue<T>(ConfigElement<T> element)
        {
            if (Config.TryGetEntry(element.Group ?? CTG_NAME, element.Name, out ConfigEntry<T> configEntry))
            {
                return configEntry.Value;
            }

            throw new Exception("Could not get config entry '" + element.Name + "'");
        }

        public override void SetConfigValue<T>(ConfigElement<T> element, T value)
        {
            if (Config.TryGetEntry(element.Group ?? CTG_NAME, element.Name, out ConfigEntry<T> configEntry))
            {
                configEntry.Value = value;
            }
            else
            {
                ULogger.Log("Could not get config entry '" + element.Name + "'");
            }
        }

        public override void LoadConfig()
        {
            foreach (var entry in ConfigManager.ConfigElements)
            {
                var key = entry.Key;
                ConfigDefinition def = new(key.Category ?? CTG_NAME, key.Name);
                if (Config.ContainsKey(def) && Config[def] is { } configEntry)
                {
                    var config = entry.Value;
                    config.BoxedValue = configEntry.BoxedValue;
                }
            }
        }

        public override void ReloadFile()
        {
            Config.Reload();
            LoadConfig();
        }

        public override void SaveConfig()
        {
            Config.Save();
        }
    }
}

#endif
