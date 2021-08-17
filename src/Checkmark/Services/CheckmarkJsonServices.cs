/*
 * This class provides JSON (JavaSctipt Object Notation) de/serialization services.
 */

using System.Text.Json;
using Checkmark.Templates;
using System.Collections;

namespace Checkmark.Services
{
    public class CheckmarkJsonServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        #region JSON services for the user's Checkmark list
        public static string Serialize(CheckmarkItem json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static CheckmarkItem Deserialize(string json)
        {
            return JsonSerializer.Deserialize<CheckmarkItem>(json, jsonSerializerOptions);
        }
        #endregion

        #region JSON services for Checkmark files configuration
        public static string Serialize(CheckmarkConfig json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static CheckmarkConfig Deserialize<CheckmarkConfig>(string json)
        {
            return JsonSerializer.Deserialize<CheckmarkConfig>(json, jsonSerializerOptions);
        }
        #endregion
    }
}
