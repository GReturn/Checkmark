namespace Checkmark;

internal class CheckmarkListTemplate
{
    // TODO: Set ID
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("Title")]
    public string TodoItem { get; set; }

    [JsonPropertyName("Priority")]
    public string Priority { get; set; }

    [JsonPropertyName("Status")]
    public string Status { get; set; } = "To do";
}
    // TODO: DO THIS LATER AFTER COMPLETING VIEW FEATURE:
    //public class CheckmarkList : ArrayList
    //{
    //    public IList<CheckmarkList> ListTitle { get; set; }
    //}
}
