/*
 * This class provides services specific to the entire list of the user.
 */

using Checkmark.Templates;

namespace Checkmark.Services
{
    public class CheckmarkMainServices
    {
        public static void AddList(CheckmarkList list)
        {
            var json = CheckmarkJsonServices.Serialize(list);
            var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
            CheckmarkJsonServices.CreateJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
        }
        public static CheckmarkList ReadList()
        {
            // TODO: change?
            /*
             * Add parser?
             * Validator?
             */
            return CheckmarkListServices.GetCheckmarkList();
        }
        public void UpdateList()
        {
            // TODO: Should have ability to add more items to list and overwrite existing items in list.
        }
        public void DeleteList()
        {

        }
    }
}
