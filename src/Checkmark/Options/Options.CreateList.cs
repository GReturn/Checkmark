using System.Collections.Generic;
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
        private static void ShowCreateMenu()
        {
            #region Prompt messages and input acquisition
            var inputTitle = Prompt.Input<string>("Input title of list");
            var inputItems = Prompt.List<string>("Please add item(s) to your list");
            var inputPriority = Prompt.Select("How important is this?",
            new[]
            {
                "Urgent",
                "A bit important",
                "Not important"
            });
            var answer = Prompt.Confirm($"Are you sure to create {inputTitle}?");
            #endregion

            if (answer)
            {
                // Skips to file creation if directory exists (does not overwrite)
                Directory.CreateDirectory(DIR);

                _ = GenerateFile(inputTitle, inputPriority, inputItems);
            }
        }

        private static async Task GenerateFile(string title, string priority, IEnumerable<string> items)
        {
            var fileName = "my-lists.json";
            var pathToFileName = Path.Combine(DIR, fileName);
            var newList = new CheckmarkList
            {
                
                ListTitle = title,
                Priority = priority,
                Items = items
            };
            using var fs = File.Create(pathToFileName);
            await JsonSerializer.SerializeAsync(fs, newList);
        }
    }
}