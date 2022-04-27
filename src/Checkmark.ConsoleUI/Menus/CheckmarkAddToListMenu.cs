namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkAddToListMenu
{
    public static void ShowAddToListMenu()
    {
        var confirmToCreateNewList = ConfirmToCreateNewList();
        if (confirmToCreateNewList == false)
        {
            WriteLine("No list will be created. Thank you for using Checkmark.");
            Environment.Exit(0);
        }

        var newItem = Prompt.Input<string>("Item name?");
        var itemPriority = Prompt.Select("How important is this item?",
            new[] {
                "Urgent",
                "A bit important",
                "Not important"
                });
        var confirm = Prompt.Confirm($"Proceed to create item: {newItem}?");

        if (confirm)
        {
            switch (confirmToCreateNewList)
            {
                case true:
                    CheckmarkPublicServices.CheckmarkCreateList(newItem, itemPriority);
                    break;
                case null:
                    CheckmarkPublicServices.CheckmarkAddToList(newItem, itemPriority);
                    break;
            }
        }
    }
    public static bool? ConfirmToCreateNewList()
    {
        if (!CheckmarkSetup.CheckForListFile())
        {
            var confirmForCreateNewList = Prompt.Confirm($"Oh no! No list was found. Create a new list?");
            return confirmForCreateNewList;
        }
        return null;
    }
}