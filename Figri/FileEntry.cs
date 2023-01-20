using System.Text;
using System.Text.Json.Serialization;

namespace Figri;

public class Project
{
    [JsonPropertyName("files")]
    public List<FileEntry > Files { get; set; } = new List<FileEntry>();

    public void Save(string path)
    {
        var content = JsonUtil.Write(this);
        File.WriteAllText(path, content);
    }

    public static Project Load(string path)
    {
        var content = File.ReadAllText(path);
        return JsonUtil.Parse<Project>(path, content);
    }
}

public class FileEntry
{
    [JsonPropertyName("path")]
    public string path { get; set; }

    [JsonPropertyName("attributes")]
    public Dictionary<string, string> attributes { get; set; } = new Dictionary<string, string>();

    public FileEntry(string path)
    {
        this.path = path;
    }

    // syntax sugar
    public string Series
    {
        get
        {
            return this["series", ""];
        }
        set
        {
            this["series"] = value;
        }
    }
    public string Season
    {
        get
        {
            return this["season", ""];
        }
        set
        {
            this["season"] = value;
        }
    }
    public string Episode
    {
        get
        {
            return this["episode", ""];
        }
        set
        {
            this["episode"] = value;
        }
    }
    public string Title
    {
        get
        {
            return this["title", ""];
        }
        set
        {
            this["title"] = value;
        }
    }

    public string FilePath
    {
        get
        {
            return path;
        }
    }

    public void moveTo(string newPath)
    {
        File.Move(path, newPath);
        path = newPath;
    }

    public string this[string name, string def]
    {
        get
        {
            string n = name.ToLower();
            if (n == "path") return path;
            else if (attributes.ContainsKey(n)) return attributes[n];
            else return def;
        }
    }

    public string this[string name]
    {
        get
        {
            return this[name, ""];
        }
        set
        {
            string n = name.ToLower();
            if (n == "path") return;
            else attributes[n] = value;
        }
    }

    public List<string> match(List<string> cols)
    {
        List<string> vals = new List<string>();
        foreach (string name in cols)
        {
            vals.Add(this[name]);
        }
        return vals;
    }

    public IEnumerable<string> AttributeNames
    {
        get
        {
            yield return "path";
            foreach (KeyValuePair<string, string> kv in attributes)
            {
                yield return kv.Key;
            }
        }
    }

    public IEnumerable<KeyValuePair<string, string>> Attributes
    {
        get
        {
            return attributes;
        }
    }

    public void setupAttributes(string p)
    {
        attributes.Clear();
        string name = GetFileName(FilePath, NumberOfseperatorsIn(p));
        Dictionary<string, string> data = Extractor.extract(p, name);
        foreach (KeyValuePair<string, string> kvp in data)
        {
            this[kvp.Key] = kvp.Value;
        }
    }

    private static string GetFileName(string path, int seperatorCount)
    {
        StringBuilder sb = new StringBuilder();

        DirectoryInfo d = new FileInfo(path).Directory;
        for (int s = 0; s < seperatorCount; ++s)
        {
            sb.Insert(0, Path.DirectorySeparatorChar);
            sb.Insert(0, d.Name);
            d = d.Parent;
        }

        sb.Append(Path.GetFileNameWithoutExtension(path));

        return sb.ToString();
    }

    static int NumberOfseperatorsIn(string s)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (c == Path.DirectorySeparatorChar) ++count;
        }
        return count;
    }

    public static HashSet<string> ExtractUsedAttributes(IEnumerable<FileEntry> Infos)
    {
        HashSet<string> set = new HashSet<string>();
        foreach (FileEntry sh in Infos)
        {
            foreach (string s in sh.AttributeNames)
            {
                if (false == set.Contains(s)) set.Add(s);
            }
        }
        return set;
    }

    public static IEnumerable<string> AttributeFor(IEnumerable<FileEntry> infos, string s)
    {
        foreach (FileEntry sh in infos)
        {
            yield return sh[s];
        }
    }
}
