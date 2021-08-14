using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Checkmark.Services
{
    public class UserSettingsConfig
    {
        [JsonPropertyName("Directory")]
        public string DIR { get; set; }
        [JsonPropertyName("Filename")]
        public string FILENAME { get; set; }
        [JsonPropertyName("PATH")]
        public string PathToFileName { get; set; }
        //private bool DoesUserDirectoryExists(string directory)
        //{
        //    if (Directory.Exists(directory))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //private static UserSettings DeserializeUserSettingsJson(string jsonUserSettingsFile)
        //{
        //    return JsonSerializer.Deserialize<UserSettings>(jsonUserSettingsFile);
        //}

        //private static void Deserialize()
        //{
        //    var options = new JsonSerializerOptions
        //    {
        //        AllowTrailingCommas = true,
        //        WriteIndented = true
        //    };
        //    var json = ReadFile(PATH);

        //    JsonSerializer.Deserialize<CheckmarkListConfig>(json, options);
        //}

        //private static StreamReader ReadFile()
        //{
        //    using var fileString = File.OpenRead(PATH);
        //    using var streamReader = new StreamReader(fileString, new UTF8Encoding(false));
        //    return streamReader.ReadToEnd();
        //}
    }
}
