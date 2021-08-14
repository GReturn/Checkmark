using System.Text.Json;
using Checkmark.Templates;

namespace Checkmark.Services
{
    public class CheckmarkJsonServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        public static string Serialize(CheckmarkListTemplateJson json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static CheckmarkListTemplateJson Deserialize(string json)
        {
            return JsonSerializer.Deserialize<CheckmarkListTemplateJson>(json, jsonSerializerOptions);
        }


        public static string Serialize(CheckmarkConfig json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static CheckmarkConfig Deserialize<CheckmarkConfig>(string json)
        {
            return JsonSerializer.Deserialize<CheckmarkConfig>(json, jsonSerializerOptions);
        }
    }
}
