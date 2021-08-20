/*
 * This class provides file management services. 
 * Content may seem conflicted with CheckmarkJsonServices.cs,
 * but you should know that codes can experience
 * existential crises too! #CodeMentalHealthAwareness <3
 */

using System.IO;
using System.Text;
using System.Threading.Tasks;
using Checkmark.Templates;

namespace Checkmark.Services
{
    public static class CheckmarkFileServices
    {
        public static void CreateJsonFile(string directory, string filename, string json)
        {
            var pathToFile = Path.Combine(directory, filename);
            Directory.CreateDirectory(directory);

            if(Directory.Exists(directory))
            {
                File.WriteAllText(pathToFile, json);
            }
        }

        // TODO: make code async. Run before Sharprompt instance in CheckmarkView.cs
        public static CheckmarkItem ReadListFileJson(CheckmarkConfig config)
        {
            var configPath = Path.Combine(config.DIR, config.FILENAME);
            var jsonFile = string.Empty;

            using (var fileString = File.OpenRead(configPath))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                jsonFile = streamReader.ReadToEnd();

            return CheckmarkJsonServices.Deserialize(jsonFile);
        }
        // TODO: Merge with Deserialize<CheckmarkConfig> on CheckmarkJsonServices.cs
        public static string ReadConfigFileJson()
        {
            var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName);

            using (var fileString = File.OpenRead(pathToFile))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                return streamReader.ReadToEnd();
        }
    }
}
