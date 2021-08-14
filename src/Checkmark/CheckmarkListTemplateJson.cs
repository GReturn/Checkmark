using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Checkmark
{
    public class CheckmarkListTemplateJson
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Priority")]
        public string Priority { get; set; }
        [JsonPropertyName("Items")]
        public IEnumerable<string> Items { get; set; }
    }
}
