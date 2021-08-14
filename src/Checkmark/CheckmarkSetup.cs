using System;
using Sharprompt;
using System.IO;

namespace Checkmark
{
    public class CheckmarkSetup
    {
        public static void ShowSetupMenu()
        {
            var ready = Prompt.Confirm("Before you start writing your todo lists, please finish the setup.");

            while (ready)
            {
                var userDirectory = Prompt.Input<string>(@"Where do you want to save your lists? e.g. C:\Temp");

                if (Directory.Exists(userDirectory))
                {
                    userDirectory += @"\Checkmark";

                    Directory.CreateDirectory(userDirectory);
                    using (var fs = File.Create(Path.Combine(userDirectory, "my-list.json")))
                    {
                        fs.Write();
                    }

                }
                else
                {
                    var message = "Directory not found. ";
                    throw new DirectoryNotFoundException(message);
                }
            }
            Console.WriteLine("Set-up process could not finish.");
            Environment.Exit(0);
        }
    }
}
