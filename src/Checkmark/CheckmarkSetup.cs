using System;
using Sharprompt;
using System.IO;
using Checkmark.Services;

namespace Checkmark
{
    public class CheckmarkSetup
    {
        public static void ShowSetupMenu()
        {
            /*
             *  Messy code here. Optimize later.
             */
            var ready = Prompt.Confirm("Before you start writing your todo lists, please finish the setup.");

            while (ready)
            {
                var userDirectory = Prompt.Input<string>(@"Where do you want to save your lists? e.g. C:\Temp");

                if (Directory.Exists(userDirectory))
                {
                    userDirectory += @"\Checkmark";

                    var checkmarkConfig = new CheckmarkConfig
                    {
                        DIR = userDirectory
                    };
                    var pathToFile = checkmarkConfig.CheckmarkConfigPath;
                    var json = CheckmarkJsonServices.Serialize(checkmarkConfig);

                    CheckmarkFileServices.CreateJsonFile(checkmarkConfig.DIR,pathToFile,json);
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
