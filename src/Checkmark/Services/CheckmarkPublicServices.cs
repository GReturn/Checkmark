﻿namespace Checkmark.Services;

public class CheckmarkPublicServices
{
    public static void CheckmarkAddToList(string itemName, string itemPriority)
    {
        // TODO: https://stackoverflow.com/questions/33081102/json-add-new-object-to-existing-json-file-c-sharp

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
