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
    public static List<CheckmarkItem> ReadList()
    {
        return CheckmarkListServices.GetCheckmarkList();
    }
    public static void UpdateList(int itemID, string category, string renameWord)
    {
        // TODO: Add implementations

        /*
         * Assuming that ID feature is implemented:
         * Get CheckmarkItem.ID, then match if similar to user input ID.
         * 
         * Get CheckmarkItem property according to "category" specified.
         * These "category" should specify CheckmarkItem.Title, Checmarkitem.Priority.
         * 
         * Get category.
         * Then change content.
         * 
         * foreach(CheckmarkItem item in list)
         * if(itemID is item.ID && property is item.Property)
         * {
         *  item.Property = renameWord;
         * }
         */
        var list = ReadList();

        foreach(var item in list)
        {
            if(itemID == item.ID && item.)
            {
                var prop = JsonElement.TryGetProperty(category, renameWord);
            }
        }


    }
    public static void DeleteList()
    {
    }
}
