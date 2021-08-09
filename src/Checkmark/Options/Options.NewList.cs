using System;
using static System.Console;
using Sharprompt;
using System.IO;

namespace Checkmark
{
    public partial class Options
    {
        private var PATH = @"src/Checkmark/LocalStorage/my_data.json";
        public void NewList()
        {
            CreateList();
        }
        private void CreateList()
        {
            var inputTitle = Prompt.Input<string>("Input title of list");
            var answer = Prompt.Confirm($"Are you sure to create {inputTitle}?");
            
            if (answer)
            {
                // TODO: Generate txt file/json file. Depends. Watch: https://youtu.be/9mUuJIKq40M
                GenerateNewFile(inputTitle);
                WriteLine("new file here");
            }
        }
        private void GenerateNewFile(string title)
        {
            File.Create(PATH);
        }
    }
}