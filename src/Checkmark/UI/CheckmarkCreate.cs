using Sharprompt;
using Checkmark.Services;
using Checkmark.Templates;
using System.Collections;

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

            var newList = new CheckmarkItemListTemplateJson
            {
                Title = newListName,
                Priority = newListPriority,
                Items = newListItems
            };
            //var arrayList = new ArrayList();
            //arrayList.Add(newList);

            CheckmarkListServices.AddList(newList);
        }
    }
}
