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
        public static async Task<CheckmarkListTemplateJson> ReadListFileJson(string jsonListFile)
        {
            var jsonFile = string.Empty;

            using (var fileString = File.OpenRead(jsonListFile))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                jsonFile = await streamReader.ReadToEndAsync().ConfigureAwait(false);

            return CheckmarkJsonServices.Deserialize(jsonFile);
        }
        public static string ReadConfigFileJson()
        {
            var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName);

            using (var fileString = File.OpenRead(pathToFile))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                return streamReader.ReadToEnd();
        }
    }
}
