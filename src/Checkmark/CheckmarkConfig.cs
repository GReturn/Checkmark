using System.Text.Json.Serialization;

namespace Checkmark
{
    public class CheckmarkConfig
    {
        // Path location of checkmark-config.json
        public string Directory { get; } = "/LocalStorage/";

        public string FileName { get; } = "checkmark-config.json";

        // Contents of checkmark-config.json
        [JsonPropertyName("Directory")]
        public string DIR { get; set; }

        [JsonPropertyName("Filename")]
        public string FILENAME { get; } = "my-lists.json";
    }
}