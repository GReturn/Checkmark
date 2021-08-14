using System.IO;
using System.Text;
using System.Threading.Tasks;
using Checkmark.Templates;

namespace Checkmark.Services
{
    public static class CheckmarkFileServices
    {
        public static void CreateJsonFile(string directory, string path, string json)
        {
            Directory.CreateDirectory(directory);

            using (var fs = File.Create(path))
            {
                File.WriteAllText(path, json);
            }
                
        }

        public static void WriteToFile(string file)
        {

        }
        public static void Save()
        {

        }
        


        public static async Task<CheckmarkListTemplateJson> ReadJsonFile(string json)
        {
            var jsonFile = string.Empty;

            using (var fileString = File.OpenRead(json))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                jsonFile = await streamReader.ReadToEndAsync().ConfigureAwait(false);

            return CheckmarkJsonServices.Deserialize(jsonFile);
        }
    }
}
