namespace Checkmark.Services;
internal class CheckmarkJsonServices
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        AllowTrailingCommas = true,
        WriteIndented = true,
        IncludeFields = true,
    };
    public static string Serialize(CheckmarkListTemplate json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }
    public static string Serialize(CheckmarkConfig json)
    {
        return JsonSerializer.Serialize(json, jsonSerializerOptions);
    }
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