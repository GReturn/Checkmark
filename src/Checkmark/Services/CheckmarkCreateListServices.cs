namespace Checkmark.Services;

internal class CheckmarkCreateListServices
{
    static internal void AddFirstItemToList<T>(CheckmarkItem list)
    { 
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        var json = CheckmarkJsonServices.SerializeList<CheckmarkItem>(list);
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}
