using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using static Checkmark.Options;

namespace Checkmark.Services
{
    public class NewFile
    {
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
            var completeList = AssignListDataToArrayList(newList);

            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            using var fs = File.Create(pathToFileName);
            await JsonSerializer.SerializeAsync(fs, completeList, options);
        }
        private static ArrayList AssignListDataToArrayList(CheckmarkList checkmarkList)
        {
            ArrayList arrayList = new();
            arrayList.Add(checkmarkList);
            return arrayList;
        }
    }
}

