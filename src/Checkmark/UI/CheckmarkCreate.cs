using Sharprompt;
using Checkmark.Services;

namespace Checkmark.UI
{
    public class CheckmarkCreate
    {
        public static void ShowCreateMenu()
        {
            var newListName = Prompt.Input<string>("List name");
            var newListItems = Prompt.List<string>("Add item(s) to your list");
            var newListPriority = Prompt.Select("How important is this list?", 
                new[] { 
                    "Urgent", 
                    "A bit important", 
                    "Not important" 
                });

            var newList = new CheckmarkListTemplateJson
            {
                Title = newListName,
                Priority = newListPriority,
                Items = newListItems
            };

            CheckmarkJsonServices.SerializeList(newList);
        }
    }
}
