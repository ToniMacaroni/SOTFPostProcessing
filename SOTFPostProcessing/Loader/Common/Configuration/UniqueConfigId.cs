namespace SOTFPostProcessing.Loader.Common.Configuration;

public struct UniqueConfigId
{
    public String Name { get; }
    public String Category { get; }
    
    public UniqueConfigId(String name, String category)
    {
        Name = name;
        Category = category;
    }
}