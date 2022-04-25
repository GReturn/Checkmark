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
