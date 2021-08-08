using System;
using static System.Console;
using Sharprompt;

namespace Checkmark
{
    public partial class Options
    {
        public void NewList()
        {
            CreateList();
        }
        private void CreateList()
        {
            var title = Prompt.Input<string>("Input title of list");

            var answer = Prompt.Confirm($"Are you sure to create {title}?");
            
            if (answer)
            {
                // Generate txt file/json file. Depends.
                WriteLine("new file here");
            }
        }
    }
}