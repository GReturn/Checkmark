/*
 * This class provides services specific to the entire list of the user.
 */

using Checkmark.Templates;


namespace Checkmark.Services
{
    public class CheckmarkMainServices
    {
        public static void AddList(CheckmarkItem list)
        {
            var json = CheckmarkJsonServices.Serialize(list);
            var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
            CheckmarkFileServices.CreateJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
        }
        public static CheckmarkItem ReadList()
        {
            // TODO: change?
            /*
             * Add parser?
             */
            return CheckmarkListServices.GetCheckmarkList();
        }
        public void UpdateList()
        {
            // TODO: Should have ability to add more to list and overwrite existing items in list.
        }
        public void DeleteList()
        {

        }
    }
}
