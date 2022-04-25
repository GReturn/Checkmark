namespace Checkmark;

internal class CheckmarkConfig
{
    // Path location of checkmark-config.json
    static internal string CheckmarkConfigDirectory { get; } = "/LocalStorage/";
    static internal string CheckmarkConfigFileName { get; } = "checkmark-config.json";

    // Contents of checkmark-config.json
    [JsonPropertyName("Directory")]
    public string DIR { get; init; }
    [JsonPropertyName("Filename")]
    public string FILENAME { get; } = "my-checkmark-lists.json";

    static internal bool CheckForConfig()
    {
        if (File.Exists(Path.Combine(CheckmarkConfigDirectory,
                                         CheckmarkConfigFileName)))
        {
            return true;
        }
        return false;
    }
}