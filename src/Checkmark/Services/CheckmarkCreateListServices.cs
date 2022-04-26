namespace Checkmark.Services;

internal class CheckmarkCreateListServices
{
    static internal void AddFirstItemToList<T>(CheckmarkItem list)
    {
        /* The code below is just the same as this:
         * 
         * var newList = new List<CheckmarkItem>();
         * newList.Add(list);
         * 
         * Weird, right?
         */

        var newList = new List<CheckmarkItem>
        {
            list
        };

        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();

        var json = CheckmarkJsonServices.SerializeList<CheckmarkItem>(newList);
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}
