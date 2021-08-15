using System.Collections.Generic;
using System.Collections;
using System.Text.Json.Serialization;

namespace Checkmark.Templates
{
    public class CheckmarkItemListTemplateJson
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }
        [JsonPropertyName("Items")]
        public IEnumerable<string> Items { get; set; }
    }
    public class CheckmarkTodoList
    {
        public IList<CheckmarkItemListTemplateJson> Todos { get; set; }
    }
}
