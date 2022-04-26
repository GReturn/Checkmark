namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkMainMenu
{
    public static void Run()
    {           
        InteractiveMode();
    }
    private static void InteractiveMode()
    {
        WriteLine("Welcome back to Checkmark!");

        if(CheckmarkSetup.CheckForListFile())
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

        var commandInit = Prompt.Select("What do you wish to do?",
        new[]
        {
            "Create list",
            "Exit application"
        });
        HandleCommand(commandInit);
    }
    private static void HandleCommand(string command)
    {
        switch (command)
        {
            case "Create list":
                CheckmarkCreateListMenu.ShowCreateListMenu();
                break;
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
                Environment.Exit(0);
                break;
        }
    }
}
