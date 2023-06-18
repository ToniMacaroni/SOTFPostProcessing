#if ML
using MelonLoader;
using MelonLoader.Utils;
using SOTFPostProcessing.Loader.Common.Configuration;

namespace SOTFPostProcessing.Loader.MelonLoader
{
    public class MelonLoaderConfigHandler : ConfigHandler
    {
        internal const string CTG_NAME = UPlugin.NAME;

        public override string ConfigPath => _configPath;

        public override void Init()
        {
            _configPath = Path.Combine(MelonEnvironment.UserDataDirectory, $"{CTG_NAME}.cfg");
        }

        public override void LoadConfig()
        {
            foreach (var entry in ConfigManager.ConfigElements)
            {
                var key = entry.Key;
                if (GetCategory(key.Category)?.GetEntry(key.Name) is not null)
                {
                    var config = entry.Value;
                    config.BoxedValue = config.GetLoaderConfigValue();
                }
            }
        }

        public override void RegisterConfigElement<T>(ConfigElement<T> config)
        {
            var entry = GetCategory(config.Group, true).CreateEntry(config.Name, config.Value, null, config.Description);
            new EntryDelegateWrapper<T>(entry, config);
        }

        public override void SetConfigValue<T>(ConfigElement<T> config, T value)
        {
            if (GetCategory(config.Group, true).GetEntry<T>(config.Name) is MelonPreferences_Entry<T> entry)
            {
                entry.Value = value;
                //entry.Save();
            }
        }

        public override T GetConfigValue<T>(ConfigElement<T> config)
        {
            if (GetCategory(config.Group, true).GetEntry<T>(config.Name) is MelonPreferences_Entry<T> entry)
            {
                return entry.Value;
            }

            return default;
        }

        public override void OnAnyConfigChanged()
        { }

        public override void ReloadFile()
        {
            if (Categories.Count < 1)
            {
                return;
            }

            var cfg = Categories.First().Value;
            cfg.LoadFromFile(false);
            LoadConfig();
        }

        public override void SaveConfig()
        {
            foreach (var (name, category) in Categories)
            {
                category.SaveToFile(false);
            }
        }

        private MelonPreferences_Category GetCategory(string name, bool createIfMissing = false)
        {
            if (Categories.TryGetValue(name, out var category))
            {
                return category;
            }

            if (createIfMissing)
            {
                category = MelonPreferences.CreateCategory(name, $"{name} Settings", false, false);
                category.SetFilePath(_configPath, true, false);
                Categories.Add(name, category);
            }

            return category;
        }

        internal Dictionary<string, MelonPreferences_Category> Categories = new();

        private string _configPath;

        // This wrapper exists to handle the "LemonAction" delegates which ML now uses in 0.4.4+.
        // Reflection is required since the delegate type changed between 0.4.3 and 0.4.4.
        // A wrapper class is required to link the MelonPreferences_Entry and the delegate instance.
        public class EntryDelegateWrapper<T>
        {
            public ConfigElement<T> config;
            public MelonPreferences_Entry<T> entry;

            public EntryDelegateWrapper(MelonPreferences_Entry<T> entry, ConfigElement<T> config)
            {
                this.entry = entry;
                this.config = config;
                //var evt = entry.GetType().GetEvent("OnValueChangedUntyped");
                //evt.AddEventHandler(entry, Delegate.CreateDelegate(evt.EventHandlerType, this, GetType().GetMethod("OnChanged")));
                this.entry.OnEntryValueChangedUntyped.Subscribe(OnValueChanged);
            }

            private void OnValueChanged(object oldValue, object newValue)
            {
                if ((entry.Value == null && config.Value == null) || config.Value.Equals(newValue))
                {
                    return;
                }

                config.Value = (T)newValue;
            }
        }
    }
}
#endif
