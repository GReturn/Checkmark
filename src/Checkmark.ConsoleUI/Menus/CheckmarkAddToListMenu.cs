namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkAddToListMenu
{
    public static void ShowAddToListMenu()
    {
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
            CheckmarkPublicServices.CheckmarkAddToList(newItem,itemPriority);
        }
    }
}
