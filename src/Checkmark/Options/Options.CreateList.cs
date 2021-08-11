using static System.Console;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Sharprompt;
using System.Collections.Generic;

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
            var inputTitle = Prompt.Input<string>("Input title of list");

            var inputItems = Prompt.List<string>("Please add item(s) to your list");

            var inputPriority = Prompt.Select("How important is this?",
            new[]
            {
                "Urgent",
                "A bit important",
                "Not important"
            });
            WriteLine($"{inputTitle} ({inputPriority}): {inputItems}\n");

            var answer = Prompt.Confirm($"Are you sure to create {inputTitle}?");
            
            if (answer)
            {
                // Skips to file creation if directory exists (does not overwrite)
                Directory.CreateDirectory(DIR);

                _ = GenerateFile(inputTitle, inputPriority, inputItems);
            }
        }

        private static async Task GenerateFile(string title, string priority, IEnumerable<string> items)
        {
            var fileName = $"{title}.json";
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