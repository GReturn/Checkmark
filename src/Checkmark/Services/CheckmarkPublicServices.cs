namespace Checkmark.Services;

public class CheckmarkPublicServices
{
    public static void CheckmarkAddToList(string itemName, string itemPriority)
    {
        var newList = new CheckmarkListTemplate
        {
            TodoItem = itemName,
            Priority = itemPriority
        };
        CheckmarkAddToListServices.AddToList(newList);
    }
    public static (string itemName, string itemPriority) ReadList()
    {
        CheckmarkListServices.GetCheckmarkList();

        return (null, null);
    }
    public void UpdateList()
    {
        // TODO: Should have ability to add more items to list and overwrite existing items in list.
    }
    public void DeleteList()
    {

    }
}
