/*
 * This class provides JSON (JavaSctipt Object Notation) de/serialization services.
 */

using System.Text.Json;
using Checkmark.Templates;
using System.IO;

namespace Checkmark.Services
{
    public class CheckmarkJsonServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        #region Serializers
        public static string Serialize(CheckmarkList json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        public static string Serialize(CheckmarkConfig json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        #endregion
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
}
