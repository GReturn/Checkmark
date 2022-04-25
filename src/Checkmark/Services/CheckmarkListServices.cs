using System.Text;

namespace Checkmark.Services;

internal class CheckmarkListServices
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        AllowTrailingCommas = true,
        WriteIndented = true,
    };



    // SO MESSSSSSSSSSSSSSSSSSSSYYYYYYYYYYYYYYYYYYYYYYYY
    
    
    
    
    public static CheckmarkConfig GetCheckmarkConfig()
    {
        #region Get config file
        var configFile = string.Empty;
        var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName);

        using (var fileString = File.OpenRead(pathToFile))
        using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
            configFile = streamReader.ReadToEnd();
        #endregion
        return JsonSerializer.Deserialize<CheckmarkConfig>(configFile, jsonSerializerOptions);
    }
    public static CheckmarkListTemplate GetCheckmarkList() // TODO: Make async. Run before Sharprompt instance in CheckmarkView.cs
    {
        var checkmarkConfig = GetCheckmarkConfig();

        #region Get list file basing from config content
        var listJson = string.Empty;
        var configPath = Path.Combine(checkmarkConfig.DIR, checkmarkConfig.FILENAME);

        using (var fileString = File.OpenRead(configPath))
        using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
            listJson = streamReader.ReadToEnd();
        #endregion
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
