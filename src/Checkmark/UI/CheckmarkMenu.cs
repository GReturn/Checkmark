using System;
using Sharprompt;
using static System.Console;
using Checkmark.UI;

namespace Checkmark
{
    public static class CheckmarkMenu
    {
        public static void Run()
        {
            ShowMainMenu();
        }
        private static void ShowMainMenu()
        {
            var input = Prompt.Select("What do you wish to do?", 
            new[] 
            { 
                "Create new list", 
                "View my lists and tasks", 
                "Update", 
                "Delete",
                "Exit"
            });
            
            switch(input.ToUpper())
            {
                case "CREATE NEW LIST":
                    CheckmarkCreate.ShowCreateMenu();
                    break;
                case "VIEW MY LISTS AND TASKS":
                    WriteLine("Viewing...");
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