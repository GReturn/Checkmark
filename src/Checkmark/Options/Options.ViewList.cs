using System.IO;
using System.Text.Json;
using static System.Console;
using System.Text;

namespace Checkmark
{
    public partial class Options
    {
        public void ViewList()
        {
            ReadList();
        }
        private void ReadList()
        {
            var listsOfTasks = Deserialize(PATH);
            WriteLine(listsOfTasks);
        }

        private void ReadFile(string file)
        {
            using var fileString = File.OpenRead(PATH);
            using var streamReader = new StreamReader(fileString, new UTF8Encoding(false));
            file = streamReader.ReadToEnd();
        }

        private bool isFileExisting()
        {
            return true;
        }

        private static CheckmarkList Deserialize(string text)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            var json = ReadFile(text);

            return JsonSerializer.Deserialize<CheckmarkList>(json, options);
        }
    }
}