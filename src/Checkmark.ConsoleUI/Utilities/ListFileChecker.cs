namespace Checkmark.ConsoleUI.Utilities;

internal class ListFileChecker
{
    public static void CheckForListFile()
    {
        if (!CheckmarkSetup.CheckForListFile())
        {
            WriteLine("No list file was detected. Please create a list first.");
            CheckmarkMainMenu.Run();
        }
    }
}
