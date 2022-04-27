namespace Checkmark.Services;

public class CheckmarkPublicServices
{
    public static void CheckmarkCreateList(string itemName, string itemPriority)
    {

        var newItem = new CheckmarkItem
        {
            TodoItem = itemName,
            Priority = itemPriority
        };
        CheckmarkCreateListServices.AddFirstItemToList<CheckmarkItem>(newItem);
    }
    public static void CheckmarkAddToList(string itemName, string itemPriority)
    {
        // TODO: https://stackoverflow.com/questions/33081102/json-add-new-object-to-existing-json-file-c-sharp

        var newList = new CheckmarkItem
        {
            TodoItem = itemName,
            Priority = itemPriority
        };
        CheckmarkAddToListServices.AddToList<CheckmarkItem>(newList);
    }
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
