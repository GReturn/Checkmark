namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkViewListMenu
{
    public static void ShowViewMenu()
    {
        var viewListChoice = Prompt.Select("How do you want to view your lists?",
            new[] {
                "In a table"
            });
        HandleViewChoice(viewListChoice);
    }
    private static void HandleViewChoice(string viewChoice)
    {
        var list = CheckmarkPublicServices.ReadList();

        switch (viewChoice)
        {
            case "In a table":
            default:
                //TableCreator.MakeListTable(list);
                break;
            
        }
    }
}