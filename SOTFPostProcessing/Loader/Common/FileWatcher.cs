namespace SOTFPostProcessing.Loader.Common;

public class FileWatcher
{
    public bool Enabled;
    public event Action OnFileChanged;

    private string _filePath;

    public FileWatcher(string filePath)
    {
        _filePath = filePath;
        
        CreateWatcher();
        Enabled = true;
    }

    protected void CreateWatcher()
    {
        if(_watcher != null)
            return;
        
        _watcher = new FileSystemWatcher
        {
            Path = Path.GetDirectoryName(_filePath)!,
            Filter = Path.GetFileName(_filePath)!,
            NotifyFilter = NotifyFilters.LastWrite,
            EnableRaisingEvents = true
        };

        _watcher.Changed += OnWatcherChange;
    }
    
    private async void OnWatcherChange(object sender, FileSystemEventArgs e)
    {
        if (!Enabled)
        {
            return;
        }
        
        await Task.Delay(100);
        
        var timeSinceLastRead = DateTime.Now - _lastReadTime;
        
        if (timeSinceLastRead.TotalSeconds < 0.5f)
        {
            return;
        }
        
        if (_isReading)
        {
            return;
        }
        
        _isReading = true;
        _lastReadTime = DateTime.Now;
        
        try
        {
            UHelpers.InvokeOnMainThread(OnFileChanged);
        }
        catch (Exception exception)
        {
            ULogger.Log(exception);
        }
        
        _isReading = false;
    }
    
    private FileSystemWatcher _watcher;
    private bool _isReading;
    private DateTime _lastReadTime = DateTime.MinValue;
}
