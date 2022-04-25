namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkViewListMenu
{
    public static void ShowViewMenu()
    {
        var viewListChoice = Prompt.Select("How do you want to view your lists?",
            new[] {
                "In a table"
            });
        var list = CheckmarkPublicServices.ReadList();
        // TableCreator.MakeListTable(list);

    }
}
