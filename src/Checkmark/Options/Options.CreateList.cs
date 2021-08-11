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
                // Skips to file creation if directory exists (does not overwrite):
                Directory.CreateDirectory(DIR);

                _ = GenerateFile(inputTitle);
            }
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
            using var fs = File.Create(pathToFileName);
            await JsonSerializer.SerializeAsync(fs, newList);
        }
    }
}