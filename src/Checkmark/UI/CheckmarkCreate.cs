using Sharprompt;
using Checkmark.Services;
using Checkmark.Templates;
using System.Collections;

namespace Checkmark.UI
{
    static internal class CheckmarkCreate
    {
        public static void ShowCreateMenu()
        {
            var newItem = Prompt.Input<string>("List name");
            var itemPriority = Prompt.Select("How important is this list?", 
                new[] { 
                    "Urgent", 
                    "A bit important", 
                    "Not important" 
                });
            var confirm = Prompt.Confirm($"Proceed to create list: {newItem}?");

            if (confirm)
            {
                var newList = new CheckmarkItem
                {
                    TodoItem = newItem,
                    Priority = itemPriority
                };
                //var arrayList = new ArrayList();
                //arrayList.Add(newList);

                CheckmarkListServices.AddList(newList);
            }
            
        }
    }
}
