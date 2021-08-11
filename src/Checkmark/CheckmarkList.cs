using System.Collections.Generic;

namespace Checkmark
{
    public class CheckmarkList
    {
        public string ListTitle { get; set; }
        public string Priority { get; set; }
        public IEnumerable<string> Items { get; set; }
    }
}