namespace Checkmark;

public class CheckmarkItem
{
    [JsonPropertyName("Id")]
    public int ID { get; set; } = 1;

    [JsonPropertyName("Title")]
    public string TodoItem { get; set; }

    [JsonPropertyName("Priority")]
    public string Priority { get; set; }

    [JsonPropertyName("Status")]
    public string Status { get; set; } = "To do";
    /*
     * Status: To do, doing, done
     */
}
