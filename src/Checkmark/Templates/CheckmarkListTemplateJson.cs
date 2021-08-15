using System.Collections.Generic;
using System.Collections;
using System.Text.Json.Serialization;

namespace Checkmark.Templates
{
    public class CheckmarkListTemplateJson : ArrayList
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }
        [JsonPropertyName("Items")]
        public IEnumerable<string> Items { get; set; }
    }
}
