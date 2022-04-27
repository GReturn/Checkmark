namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkMainMenu
{
    public static void Run()
    {
        WriteLine("Welcome back to Checkmark!");
        InteractiveMode();
    }
    private static void InteractiveMode()
    {
        var command = Prompt.Select("What do you wish to do?",
    new[]
        {
            "Add new item to list",
            "Read my list",
            "Delete an item",
            "Exit application"
        });
        HandleCommand(command);
    }
    private static void HandleCommand(string command)
    {
        switch (command)
        {
            case "Add new item to list":
                CheckmarkAddToListMenu.ShowAddToListMenu();
                break;

            case "Read my list":
                CheckmarkViewListMenu.ShowViewMenu();
                break;
            case "Delete an item":
                WriteLine("Deleting");
                break;

            case "Exit application":

                WriteLine("Thank you for using Checkmark.");
                Environment.Exit(0);
                break;
        }
    }
}
