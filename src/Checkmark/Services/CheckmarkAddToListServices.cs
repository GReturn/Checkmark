namespace Checkmark.Services;

internal class CheckmarkAddToListServices
{
    static internal void AddToList<T>(CheckmarkItem newItem)
    {
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        var listData = CheckmarkListServices.GetCheckmarkList();

        listData.Add(newItem);

        var json = CheckmarkJsonServices.SerializeList<CheckmarkItem>(listData);

        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, 
                                        checkmarkConfig.FILENAME, 
                                        json);
    }
}