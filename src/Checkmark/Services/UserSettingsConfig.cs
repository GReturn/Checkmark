using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Checkmark.Services
{
    public class UserSettingsConfig
    {
        public class ListFileLocation
        {
            [JsonPropertyName("Directory")]
            public string DIR { get; set; }
            [JsonPropertyName("Filename")]
            public string FILENAME { get; set; }
            [JsonPropertyName("PATH")]
            public string PathToListFileName { get; set; }
        }
        public class ConfigFileLocation
        {
            [JsonPropertyName("Directory")]
            public static string DIR { get; } = "/LocalStorage/";
            [JsonPropertyName("Filename")]
            public static string FILENAME { get; } = "my-config.json";
            [JsonPropertyName("Path")]
            public static string PathToFileName { get; } = Path.Combine(DIR, FILENAME);
        }

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
