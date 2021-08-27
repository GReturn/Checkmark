using System.Collections;
using System.Text.Json.Serialization;

namespace Checkmark.Templates
{
    public class CheckmarkList : ArrayList
    {
        [JsonPropertyName("Item")]
        public CheckmarkItem Item { get; set; }

        /*
         * Make it look like this:
         *
         *  list [
         *      index_01 {
         *          "ItemName":"itemName",
         *          "Priority":"Important"
         *          "Status":"To do"
         *      }
         *      index_02 {
         *
         *      }
         *
         * ]
         */
    }

    public class CheckmarkItem
    {
        [JsonPropertyName("ItemName")]
        public string TodoItem { get; set; }

        [JsonPropertyName("Priority")]
        public string Priority { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; } = "To do";
    }
}