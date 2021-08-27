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