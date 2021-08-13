using System;
using Sharprompt;
using static System.Console;

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
                    UI.CreateList();
                    break;
                case "VIEW MY LISTS AND TASKS":
                    UI.ViewList();
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