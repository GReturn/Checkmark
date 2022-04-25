namespace Checkmark;

public class CheckmarkConfig
{
    // Path location of checkmark-config.json
    static internal string CheckmarkConfigDirectory { get; } = "/LocalStorage/";
    static internal string CheckmarkConfigFileName { get; } = "checkmark-config.json";

    // Contents of checkmark-config.json
    [JsonPropertyName("Directory")]
    internal string DIR { get; set; }
    [JsonPropertyName("Filename")]
    internal string FILENAME { get; } = "my-lists.json";

    public static bool CheckForConfig()
    {
        if (File.Exists(Path.Combine(CheckmarkConfigDirectory,
                                         CheckmarkConfigFileName)))
        {
            return true;
        }
        return false;
    }
}