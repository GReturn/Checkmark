using System.Text.Json.Serialization;
using System.IO;

namespace Checkmark
{
    public class CheckmarkConfig
    {
        // Path location of checkmark-config.json
        public static string CheckmarkConfigDirectory { get; } = "/LocalStorage/";
        public static string CheckmarkConfigFileName { get; } = "checkmark-config.json";

        // Contents of checkmark-config.json
        [JsonPropertyName("Directory")]
        public string DIR { get; set; }
        [JsonPropertyName("Filename")]
        public string FILENAME { get; } = "my-lists.json";
    }
}
