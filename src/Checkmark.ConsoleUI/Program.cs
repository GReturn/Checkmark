using Checkmark.ConsoleUI.Menus;

namespace Checkmark.ConsoleUI;

internal class MenuUI
{
    private static void Main()
    {
        WriteLine("Welcome to Checkmark");

        if (!CheckmarkConfig.CheckForConfig()) 
        {
            CheckmarkSetupMenu.ShowSetupMenu();
        }
        while (true)
        {
            CheckmarkMainMenu.Run();
        }
    }
}