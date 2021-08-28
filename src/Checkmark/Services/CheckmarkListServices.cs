using System.IO;
using System.Text;
using System.Text.Json;

using Checkmark.Templates;

namespace Checkmark.Services
{
    static internal class CheckmarkListServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        public static CheckmarkConfig GetCheckmarkConfig()
        {
            #region Get config file

            var configFile = string.Empty;
            var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName);

            using (var fileString = File.OpenRead(pathToFile))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                configFile = streamReader.ReadToEnd();

            #endregion Get config file

            return JsonSerializer.Deserialize<CheckmarkConfig>(configFile, jsonSerializerOptions);
        }

        public static CheckmarkList GetCheckmarkList() // TODO: Make async. Run before Sharprompt instance in CheckmarkView.cs
        {
            var checkmarkConfig = GetCheckmarkConfig();

            #region Get list file basing from config content

            var listJson = string.Empty;
            var configPath = Path.Combine(checkmarkConfig.DIR, checkmarkConfig.FILENAME);

            using (var fileString = File.OpenRead(configPath))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                listJson = streamReader.ReadToEnd();

            #endregion Get list file basing from config content

            return JsonSerializer.Deserialize<CheckmarkList>(listJson);
        }
    }
}