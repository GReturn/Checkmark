namespace Checkmark.Services;

internal class CheckmarkCreateListServices
{
    // TODO: study how <T> in method works!
    static internal void AddFirstItemToList<T>(CheckmarkItem item)
    {
        /* NOTE:
         * 
         * The code below is just the same as this:
         * 
         * var newList = new List<CheckmarkItem>();
         * newList.Add(list);
         * 
         * Weird, right?
         */

        var newList = new List<CheckmarkItem>
        {
            item
        };
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        var json = CheckmarkJsonServices.SerializeList<CheckmarkItem>(newList);

        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, 
                                               checkmarkConfig.FILENAME, 
                                                       json);
    }
}
