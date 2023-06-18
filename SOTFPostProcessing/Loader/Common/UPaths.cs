namespace SOTFPostProcessing.Loader.Common;

public class UPaths
{
    /// <summary>
    ///     Path to dotnet assemblies.
    /// </summary>
    public static string ManagedPath { get; }

    /// <summary>
    ///     The path to the game data folder of the currently running Unity game.
    /// </summary>
    public static string GameDataPath { get; }

    /// <summary>
    ///     The path of the currently executing program.
    /// </summary>
    public static string ExecutablePath { get; }

    /// <summary>
    ///     The directory that the currently executing process resides in.
    /// </summary>
    public static string GameRootPath { get; }

    /// <summary>
    ///     The path to the config directory.
    /// </summary>
    public static string ConfigPath { get; }

    /// <summary>
    ///     The path to the plugin folder.
    /// </summary>
    public static string PluginPath { get; }

    /// <summary>
    ///     The name of the currently executing process.
    /// </summary>
    public static string ProcessName { get; }
}
