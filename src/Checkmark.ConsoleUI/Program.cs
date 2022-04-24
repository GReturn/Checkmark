using Checkmark;
using Checkmark.ConsoleUI.Menus;

internal class MenuUI
{
    private static void Main()
    {
        Console.WriteLine("Welcome to Checkmark");

        if (!CheckmarkSetup.CheckForConfig()) 
        {
            CheckmarkSetupMenu.ShowSetupMenu();
        }
        while (true)
        {
            CheckmarkMainMenu.Run();
        }
    }
}