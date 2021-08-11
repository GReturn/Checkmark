using System;
using static System.Console;
using Sharprompt;
using System.IO;
using Checkmark;

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
                GenerateFile(inputTitle);
            }
        }
        private static void GenerateDirectory(string directoryName)
        {
            Directory.CreateDirectory(directoryName);
        }

        private void GenerateFile(string title)
        {
            var newList = new CheckmarkList
            {
                ListTitle = title,
                Priority = null,
                Items = null
            };
        }
    }
}