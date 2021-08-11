using System;
using static System.Console;
using Sharprompt;

namespace Checkmark
{ 
    public class CheckmarkMenu
    {
        public static void Run()
        {
            while(true)
            {    
                ShowMainMenu();
            }
        }
        private static void ShowMainMenu()
        {
            WriteLine(" Welcome to Checkmark");
            var input = Prompt.Select("What do you wish to do?", 
            new[] 
            { 
                "Create new list", 
                "View my lists and tasks", 
                "Update", 
                "Delete", 
                "Exit"
            });
            Options option = new();
            
            switch(input.ToUpper())
            {
                case "CREATE NEW LIST":
                    option.CreateList();
                    break;
                case "VIEW MY LISTS AND TASKS":
                    option.ViewList();
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
            }
        }
    }
}