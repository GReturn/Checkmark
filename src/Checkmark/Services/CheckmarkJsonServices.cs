using System.Text.Json;

namespace Checkmark.Services
{
    public class CheckmarkJsonServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        public static string SerializeList(CheckmarkListTemplateJson json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static CheckmarkListTemplateJson DeserializeList(string json)
        {
            return JsonSerializer.Deserialize<CheckmarkListTemplateJson>(json, jsonSerializerOptions);
        }
    }
}
