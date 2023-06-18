namespace SOTFPostProcessing.Loader.Common;

public class ULogger
{
    public static ULogger Instance { get; private set; }

    public static void CreateLogger(ILoader loader)
    {
        Instance = new ULogger
        {
            _loader = loader
        };
    }

    public static void Log(object msg)
    {
        Instance?._loader.OnLogMessage(msg);
    }

    private ILoader _loader;
}
