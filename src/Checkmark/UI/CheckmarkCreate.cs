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
            var itemPriority = Prompt.Select("How important is this item?", 
                new[] { 
                    "Urgent", 
                    "A bit important", 
                    "Not important" 
                });
            var confirm = Prompt.Confirm($"Proceed to create item: {newItem}?");

            if (confirm)
            {
                // TODO: 
                var id = CheckmarkItemServices.CreateItemId();

                var newList = new CheckmarkList
                {
                    Id = id,
                    TodoItem = newItem,
                    Priority = itemPriority
                };

                CheckmarkMainServices.AddList(newList);
            }
            
        }
    }
}
