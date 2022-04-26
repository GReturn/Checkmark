namespace Checkmark.Services;
internal class CheckmarkJsonServices
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        AllowTrailingCommas = true,
        WriteIndented = true
    };

    #region Serializers

    public static string SerializeList<List>(List<CheckmarkListTemplate> json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }
    public static string SerializeConfig(CheckmarkConfig json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }

    #endregion

    #region Deserializers

    public static CheckmarkConfig DeserializeConfigFile(string configFile)
    {
        return JsonSerializer.Deserialize<CheckmarkConfig>(configFile, jsonSerializerOptions);
    }
    public static List<CheckmarkListTemplate> DeserializeList<List>(string listFile)
    {
        return JsonSerializer.Deserialize<List<CheckmarkListTemplate>>(listFile, jsonSerializerOptions);
    }

    #endregion

    public static void WriteToJsonFile(string directory, string filename, string json)
    {
        var pathToFile = Path.Combine(directory, filename);

        /* 
         * If directory exists, CreateDirectory() will NOT create another directory.
         * https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.createdirectory?view=net-6.0
         * 
         * This is why, in the next line, if directory exists, we simply overwrite it.
         */
        Directory.CreateDirectory(directory);

        if (Directory.Exists(directory))
        {
            File.WriteAllText(pathToFile, json);
        }
    }
}