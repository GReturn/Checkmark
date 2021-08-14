using System.IO;
using System.Text.Json;
using Checkmark.Services;
using Sharprompt;
using static System.Console;

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
                    @"e.g. C:\Users\YourName\");
                var userSpecifiedFileName = Prompt.Input<string>("Please specify the name of the file.");

                var userSettingsConfig = new UserSettingsConfig
                {
                    DIR = userSpecifiedDirectory,
                    FILENAME = userSpecifiedFileName,
                    PathToFileName = Path.Combine(userSpecifiedDirectory, userSpecifiedFileName)
                };
                JsonSerializer.Serialize<UserSettingsConfig>(userSettingsConfig);
            }
        }
    }
}
