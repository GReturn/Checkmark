namespace Checkmark.Services;

internal class CheckmarkAddToListServices
{
    static internal void AddToList<T>(CheckmarkItem list)
    {
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        var listData = CheckmarkListServices.GetCheckmarkList();

        listData.Add(list);

        var json = CheckmarkJsonServices.SerializeList<CheckmarkItem>(listData);
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}