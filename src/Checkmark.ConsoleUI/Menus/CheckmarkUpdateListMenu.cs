namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkUpdateListMenu
{
    public static void ShowEditMenu()
    {
        ListFileChecker.CheckForListFile();
        TableCreator.MakeListTable();

        var list = ReadList();

        var userChoiceID = Prompt.Input<int>("Input the ID number of the item");
        var userChoiceCategory = Prompt.Select("Select the column.",
            new[] {
                "Item name",
                "Priority",
                "Cancel"
            });

        if(userChoiceCategory is "Cancel")
        {
            CheckmarkMainMenu.Run();
        }
        UpdateList(userChoiceID, userChoiceCategory);
    }
}
