using Sharprompt;
using Checkmark.Services;

namespace Checkmark
{
    public static partial class UI
    { 
        public static void CreateMenu()
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
                var file = NewFile.GenerateTodoListFile(inputTitle, inputPriority, inputItems);
                /*
                TODO:
                    1. Check if directory DIR exists, if not, ask user:
                        var inputDIR = Prompt.Input<string>("Select a directory path (folder) for your todo lists");
                        // if directory is unaccessible: UnauthorizedAccessException - https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception
                        
                    2. If directory exists, file should exist, if not create file.
                        If yes: http://www.mukeshkumar.net/articles/csharp/crud-operation-with-json-file-data-in-csharp
                 
                */
            }
        }
    }
}