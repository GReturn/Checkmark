using System;

using Checkmark.UI;

using Sharprompt;

using static System.Console;

namespace Checkmark
{
    static internal class CheckmarkMenu
    {
        public static void Run()
        {
            // Apply DI here
            InteractiveMode();
        }

        private static void InteractiveMode()
        {
            var input = Prompt.Select("What do you wish to do?",
            new[]
            {
                "Create new list",
                "View my tasks",
                "Add tasks", // TODO: Merge with create new list. Do this after finishing MVP.
                "Remove tasks",
                "Exit"
            });

            switch (input.ToUpper())
            {
                case "CREATE NEW LIST":
                    CheckmarkCreate.ShowCreateMenu();
                    break;

                case "VIEW MY TASKS":
                    CheckmarkView.ShowViewMenu();
                    break;

                case "UPDATE":
                    WriteLine("Updating...");
                    break;

                case "REMOVE TASKS":
                    WriteLine("Deleting...");
                    break;

                case "EXIT":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}