using System.Linq;

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
        var list = ReadList();

        foreach(var item in list)
        {
            if(itemID == item.ID)
            {
                item.TodoItem = renameWord;

                switch (category)
                {
                    case "Priority":
                        item.Priority
                        break;
                }
            }
        }
    }
    public static void UpdateList(int itemID, string category)
    {
        var list = ReadList();

        foreach (var item in list)
        {
            if (itemID == item.ID)
            {
                switch(category)
                {
                    case "Priority":
                        item.Priority
                        break;
                }
            }
        }
    }
    public static void DeleteList()
    {
    }
}
