using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Checkmark.Services
{
    public class CheckmarkFileServices
    {
        public void CreateFile(string file)
        {
            File.Create(file);
        }

        public void WriteToFile(string file)
        {

        }
        public void Save()
        {

        }
        


        public static async Task<CheckmarkListTemplateJson> ReadListJson(string json)
        {
            var jsonFile = string.Empty;

            using (var fileString = File.OpenRead(json))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                jsonFile = await streamReader.ReadToEndAsync().ConfigureAwait(false);

            return JsonSerializer.Deserialize<CheckmarkListTemplateJson>(jsonFile);
        }
    }
}
