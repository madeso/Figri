using System.Text.Json;

namespace Figri;

public static class JsonUtil
{
    public static T Parse<T>(string file, string content)
        where T : class
    {
        try
        {
            var loaded = JsonSerializer.Deserialize<T>(content);
            if (loaded == null) { throw new Exception("internal error"); }
            return loaded;
        }
        catch (JsonException)
        {
            return null;
        }
        catch (NotSupportedException)
        {
            return null;
        }
    }

    internal static string Write<T>(T self)
    {
        return JsonSerializer.Serialize<T>(self, new JsonSerializerOptions
        {
            WriteIndented = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        });
    }
}