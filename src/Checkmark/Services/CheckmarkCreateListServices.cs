namespace Checkmark.Services;

internal class CheckmarkCreateListServices
{
    static internal void AddFirstItemToList(CheckmarkListTemplate list)
    { 

        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        var json = CheckmarkJsonServices.SerializeList<List<CheckmarkListTemplate>>(list);
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}
