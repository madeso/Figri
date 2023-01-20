namespace Figri;

public class MediaAction
{
    public string Source { get { return Show.FilePath; } }
    public string Target { set; get; }
    public FileEntry Show { set; get; }
}
