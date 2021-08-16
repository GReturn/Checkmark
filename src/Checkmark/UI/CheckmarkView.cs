using Sharprompt;

namespace Checkmark.UI
{
    static internal class CheckmarkView
    {
        public static void ShowViewMenu()
        {
            var viewListChoice = Prompt.Select("How do you want to view your lists?",
                new[] {
                    "In a table", // TODO: Feature - Add ConsoleTables: https://github.com/khalidabuhakmeh/ConsoleTables
                    "A bit important",
                    "Not important"
                });
        }
    }
}
