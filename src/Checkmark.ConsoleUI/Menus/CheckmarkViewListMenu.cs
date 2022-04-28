﻿namespace Checkmark.ConsoleUI.Menus;

internal class CheckmarkViewListMenu
{
    public static void ShowViewMenu()
    {
        CheckForListFile();

        var viewListChoice = Prompt
            .Select("How do you want to view your lists?",
            new[] {
                "In a table",
                "Cancel"
            });
        HandleViewChoice(viewListChoice);
    }
    private static void HandleViewChoice(string viewChoice)
    {
        switch (viewChoice)
        {
            case "In a table":
                TableCreator.MakeListTable();
                break;
            case "Cancel":
                CheckmarkMainMenu.Run();
                break;
        }
    }
    private static void CheckForListFile()
    {
        if(!CheckmarkSetup.CheckForListFile())
        {
            WriteLine("No list file was detected. Please create a list first.");
            CheckmarkMainMenu.Run();
        }
    }
}