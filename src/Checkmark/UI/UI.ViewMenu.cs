using System.IO;
using System.Text;
using System.Text.Json;
using Sharprompt;
using static System.Console;

namespace Checkmark
{
    public partial class UI
    {
        /*
            TODO: Add JSON file reading mechanic.
            
            Logic I built up so far:
                * Search directory
                * Open file
                * Read file
                * Deserialize JSON
        */

        public static void ViewList()
        {
            if (Directory.Exists(DIR))
            {
                ReadList();
            }
            var answer = Prompt.Confirm($"You are missing a directory and a file. Proceed to create both?");
            if (answer)
            {
                CreateList();
            }
        }
        private static void ReadList()
        {
            Deserialize();
            WriteLine();
        }

        private static void Deserialize()
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            var json = ReadFile(PATH);

            JsonSerializer.Deserialize<CheckmarkListConfig>(json, options);
        }

        private static StreamReader ReadFile()
        {
            using var fileString = File.OpenRead(PATH);
            using var streamReader = new StreamReader(fileString, new UTF8Encoding(false));
            return streamReader.ReadToEnd();
        }
    }
}