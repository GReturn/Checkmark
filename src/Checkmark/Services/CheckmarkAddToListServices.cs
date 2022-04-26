namespace Checkmark.Services;

internal class CheckmarkAddToListServices
{
    static internal void AddToList(CheckmarkListTemplate list)
    {
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();

        if (CheckmarkFileServices.CheckForExistingListFile())
        {
            CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME,);
        }

        var listData = CheckmarkListServices.GetCheckmarkList();

        listData.Add(list);

        var json = CheckmarkJsonServices.SerializeList<List<CheckmarkListTemplate>>(listData);
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}