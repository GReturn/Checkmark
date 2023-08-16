namespace Checkmark.Services;

internal class CheckmarkListServices
{
    public static CheckmarkConfig GetCheckmarkConfig()
    {
        var configFile = CheckmarkFileServices.GetConfigFileData();

        return CheckmarkJsonServices.DeserializeConfigFile(configFile);
    }
    public static List<CheckmarkItem> GetCheckmarkList()
    {
        var checkmarkConfig = GetCheckmarkConfig();
        var listJson = CheckmarkFileServices.GetListDataFromConfigFile(checkmarkConfig);

        return CheckmarkJsonServices.DeserializeList(listJson);
    }

    static internal List<CheckmarkItem> GenerateIDForItems(List<CheckmarkItem> list)
    {
        var assignNum = 1;

        foreach (var item in list)
        {
            item.ID = assignNum;
            assignNum++;
        }
        return list;
    }
}