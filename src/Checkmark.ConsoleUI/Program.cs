﻿namespace Checkmark.ConsoleUI;

internal class MenuUI
{
    private static void Main()
    {
        WriteLine("Welcome to Checkmark!");

        if (!CheckmarkSetup.CheckForConfig()) 
        {
            CheckmarkSetupMenu.ShowSetupMenu();
        }
        while (true)
        {
            CheckmarkMainMenu.Run();
        }
    }
}