using System.Collections.Generic;

namespace Checkmark.Services;

internal class CheckmarkListServices
{
    public static CheckmarkConfig GetCheckmarkConfig()
    {
        string configFile = CheckmarkFileServices.GetConfigFileData();
        return CheckmarkJsonServices.DeserializeConfigFile(configFile);
    }
    public static List<CheckmarkListTemplate> GetCheckmarkList()
    {
        var checkmarkConfig = GetCheckmarkConfig();
        var listJson = CheckmarkFileServices.GetListDataFromConfigFile(checkmarkConfig);

        return CheckmarkJsonServices.DeserializeList<List<CheckmarkListTemplate>>(listJson);
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