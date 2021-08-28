using Checkmark.Services;
using Checkmark.Templates;

using Sharprompt;

using System.Collections.Generic;

namespace Checkmark.UI
{
    static internal class CheckmarkCreate
    {
        public static void ShowCreateMenu()
        {
            var itemName = Prompt.Input<string>("List name");
            var itemPriority = Prompt.Select("How important is this item?",
                new[] {
                    "Urgent",
                    "A bit important",
                    "Not important"
                });
            var confirm = Prompt.Confirm($"Proceed to create item: {itemName}?");

            if (confirm)
            {
                var newList = new List<CheckmarkItem>
                {
                    new CheckmarkItem { TodoItem = itemName, Priority = itemPriority }
                };

                CheckmarkMainServices.AddList(newList);
            }
        }
    }
}