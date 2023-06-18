namespace SOTFPostProcessing.Loader.Common.Configuration;

public class ConfigElement<T> : IConfigElement
{
    public ConfigHandler Handler => ConfigManager.Handler;

    public T Value
    {
        get => m_value;
        set => SetValue(value);
    }

    public Action<T> OnValueChanged;

    public ConfigElement(string name, string description, T defaultValue, string group = null)
    {
        Name = name;
        Description = description;
        Group = group;

        m_value = defaultValue;
        DefaultValue = defaultValue;

        ConfigManager.RegisterConfigElement(this);
    }

    public string Name { get; }
    public string Description { get; }

    public string Group { get; set; }

    public Type ElementType => typeof(T);
    public Action OnValueChangedNotify { get; set; }

    public object DefaultValue { get; }

    object IConfigElement.BoxedValue
    {
        get => m_value;
        set => SetValue((T)value);
    }

    object IConfigElement.GetLoaderConfigValue()
    {
        return GetLoaderConfigValue();
    }

    public void RevertToDefaultValue()
    {
        Value = (T)DefaultValue;
    }

    public T GetLoaderConfigValue()
    {
        return Handler.GetConfigValue(this);
    }

    private void SetValue(T value)
    {
        if ((m_value == null && value == null) || (m_value != null && m_value.Equals(value)))
        {
            return;
        }

        m_value = value;

        Handler.SetConfigValue(this, value);

        OnValueChanged?.Invoke(value);
        OnValueChangedNotify?.Invoke();

        Handler.OnAnyConfigChanged();
    }

    private T m_value;
}
