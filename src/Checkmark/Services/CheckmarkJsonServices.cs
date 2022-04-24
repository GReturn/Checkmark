namespace Checkmark.Services;
internal class CheckmarkJsonServices
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        AllowTrailingCommas = true,
        WriteIndented = true,
    };

    public static string Serialize(CheckmarkListTemplate json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }
    public static string Serialize(CheckmarkConfig json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }

    public static void CreateJsonFile(string directory, string filename, string json)
    {
        var pathToFile = Path.Combine(directory, filename);
        Directory.CreateDirectory(directory);

        if (Directory.Exists(directory))
        {
            File.WriteAllText(pathToFile, json);
        }
    }
}
