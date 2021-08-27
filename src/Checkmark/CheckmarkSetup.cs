using System;
using System.IO;
using Checkmark.Services;
using Sharprompt;

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

        Input:
            if (ready)
            {
                var userDirectory = Prompt.Input<string>(@"Where do you want to save your lists? e.g. C:\Temp");

                if (Directory.Exists(userDirectory))
                {
                    userDirectory += @"\Checkmark\";

                    var checkmarkConfig = new CheckmarkConfig
                    {
                        DIR = userDirectory
                    };
                    var json = CheckmarkJsonServices.Serialize(checkmarkConfig);

                    CheckmarkJsonServices.CreateJsonFile(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName, json);
                }
                else
                {
                    var message = "Directory not found.";
                    Console.WriteLine(message);
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