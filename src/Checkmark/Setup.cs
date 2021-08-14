using System.IO;
using System.Text.Json;
using Sharprompt;
using static System.Console;
using static Checkmark.Services.UserSettingsConfig;

namespace Checkmark
{
    public static class Setup
    {
        public static void ShowSetupMenu()
        {
            WriteLine("Before you start creating your todo lists. Please complete the set-up process.");
            var answer = Prompt.Confirm("Are you ready?");

            if (answer)
            {
                var userSpecifiedDirectory = Prompt.Input<string>("Please specify the directory to store your lists. " +
                    @"e.g. C:\Users\YourName");
                if (Directory.Exists(userSpecifiedDirectory))
                {
                    userSpecifiedDirectory += @"\Checkmark";
                }
                else
                {
                    var message = "Directory not found. ";
                    throw new DirectoryNotFoundException(message);
                }

                var userSpecifiedFileName = Prompt.Input<string>("Please specify the name of the file.");
                userSpecifiedFileName += ".json";

                var listFileLocationConfig = new ListFileLocation
                {
                    DIR = userSpecifiedDirectory,
                    FILENAME = userSpecifiedFileName,
                    PathToListFileName = Path.Combine(userSpecifiedDirectory, userSpecifiedFileName)
                };
                // userSettingsConfigJson = JsonSerializer.Serialize(listFileLocationConfig);

                ////////////////////////////////
                Directory.CreateDirectory(ConfigFileLocation.DIR);
                //File.Create(ConfigFileLocation.PathToFileName);

                // Write to config
                using FileStream fs = File.Create(ConfigFileLocation.PathToFileName);
                JsonSerializer.Serialize(fs, listFileLocationConfig);
                ///////////////////////////////
            }
        }
    }
}
