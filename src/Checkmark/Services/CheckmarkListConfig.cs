using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Checkmark
{
    public class CheckmarkListConfig
    {
        [JsonPropertyName("ListTitle")]
        public string ListTitle { get; set; }
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }
        [JsonPropertyName("Items")]
        public IEnumerable<string> Items { get; set; }
    }
}