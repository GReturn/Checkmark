using System.Text;

namespace Checkmark.Services;

internal class CheckmarkListServices
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        AllowTrailingCommas = true,
        WriteIndented = true,
    };

    public static CheckmarkConfig GetCheckmarkConfig()
    {
        string configFile = CheckmarkFileServices.GetConfigFileData();
        return JsonSerializer.Deserialize<CheckmarkConfig>(configFile, jsonSerializerOptions);
    }
    public static CheckmarkListTemplate GetCheckmarkList() // TODO: Make async. Run before Sharprompt instance in CheckmarkView.cs
    {
        var checkmarkConfig = GetCheckmarkConfig();
        var listJson = CheckmarkFileServices.GetListDataFromConfigFile(checkmarkConfig);

        return JsonSerializer.Deserialize<CheckmarkListTemplate>(listJson);
    }

    /* TODO: generate IDs for items in list. Just generate ID in numerical order using for loop. 
     * No need to using ID generators. That would be overengineering it!
     */
    public static int CreateItemId()
    {
        // check for existing IDs
        // create new ID.
        return 1;
    }
}