using System;
using static System.Console;
using Sharprompt;
namespace Checkmark.Commands
{
    public class Create
    {
        public Create()
        {
            ShowCreateMenu();
        }

        private void ShowCreateMenu()
        {
            var input = Prompt.Select("What do you wish to do?", new[] 
            { 
                "Create new list", 
                "Back",
                "Back to main menu",
                "What is this?" 
            });

            switch(input.ToUpper())
            {
                case "CREATE NEW LIST":
                    CreateTodo();
                    break;
                case "BACK":
                    break;
                case "BACK TO MAIN MENU":
                    break;
                case "WHAT IS THIS?":
                    break;
                default:
                    WriteLine("a");
            }
        }
        private void CreateTodo()
        {

        }
    }
}