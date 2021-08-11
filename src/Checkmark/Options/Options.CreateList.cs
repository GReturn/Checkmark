using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Sharprompt;

namespace Checkmark
{
    public partial class Options
    { 
        public void CreateList()
        {
            ShowCreateMenu();
        }
        private void ShowCreateMenu()
        {
            var inputTitle = Prompt.Input<string>("Input title of list");
            var answer = Prompt.Confirm($"Are you sure to create {inputTitle}?");
            //var newList = CheckmarkList;
            
            if (answer)
            {
                GenerateDirectory(DIR);

                // if directory exists, ignore overwrite and proceed:
                _ = GenerateFile(inputTitle);
            }
        }
        private static void GenerateDirectory(string directoryName)
        {
            Directory.CreateDirectory(directoryName);
        }

        private static async Task GenerateFile(string title)
        {
            var fileName = $"{title}.json";
            var pathToFileName = Path.Combine(DIR, fileName);
            var newList = new CheckmarkList
            {
                ListTitle = title,
                Priority = null,
                Items = null
            };
            var jsonFile = JsonSerializer.Serialize(newList);
            using var fs = File.Create(pathToFileName);
            await JsonSerializer.SerializeAsync(fs, newList);
        }
    }
}