namespace Checkmark;

internal class CheckmarkItem
{
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
