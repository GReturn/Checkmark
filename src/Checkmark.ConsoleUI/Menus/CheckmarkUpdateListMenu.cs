﻿namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkUpdateListMenu
{
    public static void ShowEditMenu()
    {
        ListFileChecker.CheckForListFile();
        TableCreator.MakeListTable();

        var list = ReadList();

        var userChoiceID = Prompt.Input<int>("Input the ID number of the item.");
        var userChoiceCategory = Prompt.Select("Select the column.",
            new[] {
                "Item name",
                "Priority",
                "Cancel"
            });

        switch (userChoiceCategory)
        {
            case "Item name":
                userChoiceCategory = "Title";
                var userRenameItemProperty = Prompt.Input<string>("Input the new name of your selection.");
                UpdateList(userChoiceID, userChoiceCategory, userRenameItemProperty);
                break;
            case "Priority":
                userChoiceCategory = "Priority";
                UpdateList(userChoiceID, userChoiceCategory);
                break;
            case "Cancel":
                CheckmarkMainMenu.Run();
                break;
        }
    }
}