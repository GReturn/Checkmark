namespace Checkmark.Services;

public class CheckmarkPublicServices
{
    public static void CheckmarkCreateList(string itemName, string itemPriority)
    {

        var newItemInNewList = new CheckmarkItem
        {
            TodoItem = itemName,
            Priority = itemPriority
        };
        CheckmarkCreateListServices.AddFirstItemToList<CheckmarkItem>(newItemInNewList);
    }
    public static void CheckmarkAddToList(string itemName, string itemPriority)
    {
        var newItem = new CheckmarkItem
        {
            TodoItem = itemName,
            Priority = itemPriority
        };
        CheckmarkAddToListServices.AddToList<CheckmarkItem>(newItem);
    }

    // TODO: For table
    public static (string itemName, string itemPriority) ReadList()
    {
        // TODO: here:
        CheckmarkListServices.GetCheckmarkList();

        return (null, null);
    }
    public void UpdateList()
    {        
    }
    public void DeleteList()
    {
    }
}
