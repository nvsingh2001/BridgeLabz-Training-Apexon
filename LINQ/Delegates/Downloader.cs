namespace LINQ.Delegates;

public class DownloadEventArgs : EventArgs
{
    public string FileName { get; }

    public DownloadEventArgs(string fileName)
    {
        FileName = fileName;
    }
}

public class Downloader
{
    public event EventHandler<DownloadEventArgs> DownloadCompleted;

    public void OnDownloadCompleted(DownloadEventArgs e)
    {
        DownloadCompleted?.Invoke(this, e);
    }

    public void Download(string fileName)
    {
        Console.WriteLine($"Downloading {fileName}...");
        OnDownloadCompleted(new DownloadEventArgs(fileName));
    }
}