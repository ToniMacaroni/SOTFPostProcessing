namespace SOTFPostProcessing.Loader.Common.Configuration;

public interface IConfigElement
{
    string Name { get; }
    string Description { get; }

    string Group { get; set; }

    Type ElementType { get; }

    object BoxedValue { get; set; }
    object DefaultValue { get; }

    Action OnValueChangedNotify { get; set; }

    object GetLoaderConfigValue();

    void RevertToDefaultValue();
}
