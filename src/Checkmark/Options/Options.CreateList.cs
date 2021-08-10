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
            var newList = CheckmarkList;
            
            if (answer)
            {
                GenerateNewFile(inputTitle);
            }
        }
        private void GenerateNewFile(string title)
        {
            var newDir = Directory.CreateDirectory(DIR);
            var newFile = File.Create($"");
        }
    }
}