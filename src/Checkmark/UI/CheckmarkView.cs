using Sharprompt;
using static System.Console;
using Checkmark.Services;

namespace Checkmark.UI
{
    static internal class CheckmarkView
    {
        public static void ShowViewMenu()
        {
            var viewListChoice = Prompt.Select("How do you want to view your lists?",
                new[] {
                    "In a table", // TODO: Feature - Add ConsoleTables: https://github.com/khalidabuhakmeh/ConsoleTables
                    "No",
                    "None"
                });
            var list = CheckmarkMainServices.ReadList();
            WriteLine($"{list.Priority} | {list.TodoItem} | {list.Status}");
        }
    }
}
