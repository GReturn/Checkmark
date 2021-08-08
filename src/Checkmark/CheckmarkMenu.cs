using System;
using static System.Console;
using Sharprompt;

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

            WriteLine(" Welcome to Checkmark");
            
            var input = Prompt.Select("What do you wish to do?", 
            new[] 
            { 
                "Create new list", 
                "Read", 
                "Update", 
                "Delete", 
                "Exit" 
            });
            Options option = new();
            
            switch(input.ToUpper())
            {
                case "CREATE NEW LIST":
                    option.NewList();
                    break;
                case "READ":
                    WriteLine("Reading...");
                    break;
                case "UPDATE": 
                    WriteLine("Updating...");
                    break;
                case "DELETE":
                    WriteLine("Deleting...");
                    break;
                case "EXIT":
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine($"Error: Input invalid => {input}");
                    break;
            }
        }
    }
}