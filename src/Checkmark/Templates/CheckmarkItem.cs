using System.Collections.Generic;
using System.Collections;
using System.Text.Json.Serialization;

namespace Checkmark.Templates
{
    public class CheckmarkItem
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Title")]
        public string TodoItem { get; set; }

        [JsonPropertyName("Priority")]
        public string Priority { get; set; }

        [JsonPropertyName("Items")]
        public string Status { get; set; } = "To do";
    }
    // DO THIS LATER AFTER COMPLETING VIEW FEATURE:
    public class CheckmarkList : ArrayList
    {
        public IList<CheckmarkItem> ListTitle { get; set; }
    }
}
