using System;
using static System.Console;
using Sharprompt;
using Checkmark.Commands;

namespace Checkmark
{ 
    public class CheckmarkMenu
    {
        private const string prefix = ">>"; 
        public static void Run()
        {
            while(true)
            {    
                ShowMainMenu();
            }
        }
        private static void ShowMainMenu()
        {
            Write(prefix);

            WriteLine(" Welcome.");
            
            var input = Prompt.Select("What do you wish to do?", new[] { "Create", "Read", "Update", "Delete", "Exit" });
            
            switch(input.ToUpper())
            {
                case "CREATE":
                    WriteLine("Creating...");
                    Create();
                    break;
                case "READ":
                    WriteLine("Reading...");
                    break;
                case "UPDATE": 
                    WriteLine("Updating");
                    break;
                case "DELETE":
                    WriteLine("Deleting...");
                    break;
                case "EXIT":
                    Environment.Exit(0);
                default:
                    WriteLine($"Error: Input invalid => {input}");
            }
        }
    }
}