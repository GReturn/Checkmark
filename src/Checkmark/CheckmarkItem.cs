namespace Checkmark;

public class CheckmarkItem
{
    [JsonPropertyName("Id")]
    public int ID { get; internal set; } = 1;

    [JsonPropertyName("Title")]
    public string TodoItem { get; internal set; }

    [JsonPropertyName("Priority")]
    public string Priority { get; internal set; }

    [JsonPropertyName("Status")]
    public string Status { get; internal set; } = "To do";
    /*
     * Status: To do, doing, done
     */
}
