using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Checkmark.Services
{
    public static class NewFile
    {
        static internal Task GenerateTodoListFile(string title, string priority, IEnumerable<string> items)
        {
            var newList = new CheckmarkListConfig
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
            using var fs = File.Create(UserSettingsConfig.ConfigFileLocation.PathToFileName);
            return JsonSerializer.SerializeAsync(fs, completeList, options);
        }
        private static ArrayList AssignListDataToArrayList(CheckmarkListConfig checkmarkList)
        {
            ArrayList arrayList = new();
            arrayList.Add(checkmarkList);
            return arrayList;
        }
    }
}