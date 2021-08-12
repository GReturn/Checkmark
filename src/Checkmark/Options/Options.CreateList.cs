using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Sharprompt;

namespace Checkmark
{
    public partial class Options
    { 
        public void CreateList()
        {
            ShowCreateMenu();
        }
        private static void ShowCreateMenu()
        {
            #region Prompt messages and input acquisition
            var inputTitle = Prompt.Input<string>("Input title of list");
            var inputItems = Prompt.List<string>("Please add item(s) to your list");
            var inputPriority = Prompt.Select("How important is this?",
            new[]
            {
                "Urgent",
                "A bit important",
                "Not important"
            });
            var answer = Prompt.Confirm($"Are you sure to create {inputTitle}?");
            #endregion

            if (answer)
            {
                /*
                    1. Check if directory DIR exists, if not, ask user:
                        var inputDIR = Prompt.Input<string>("Select a directory path (folder) for your todo lists");
                        // if directory is unaccessible: UnauthorizedAccessException - https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception
                        
                    2. If directory exists, 
                 
                */
                // Skips to file creation if directory exists (does not overwrite)
                //Directory.CreateDirectory(DIR);

                //_ = GenerateFile(inputTitle, inputPriority, inputItems);
            }
        }
    }
}