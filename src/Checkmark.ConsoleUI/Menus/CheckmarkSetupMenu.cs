namespace Checkmark.ConsoleUI.Menus
{
    internal class CheckmarkSetupMenu
    {
        public static void ShowSetupMenu()
        {
            var ready = Prompt.Confirm("Before you start writing your todo lists, please finish the setup.");

            Input:
            if (ready)
            {
                var userDirectory = Prompt.Input<string>(@"Where do you want to save your lists? e.g. C:\Temp");

                if(Directory.Exists(userDirectory)) 
                {
                    CheckmarkSetup.AddDirectory(userDirectory);                
                }
                else
                {
                    Console.WriteLine("Directory not found.");
                    goto Input;
                }
            }
            else
            {
                Console.WriteLine("Set-up process could not finish.");
                Environment.Exit(0);
            }
        }

    }
}
