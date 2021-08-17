using Checkmark.Templates;

namespace Checkmark.Services
{
    public class CheckmarkListServices
    {
        public static void AddList(CheckmarkItem list)
        {
            var json = CheckmarkJsonServices.Serialize(list);
            var configFile = CheckmarkFileServices.ReadConfigFileJson();
            var checkmarkConfig = CheckmarkJsonServices.Deserialize<CheckmarkConfig>(configFile);
            CheckmarkFileServices.CreateJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
        }
        public void ReadList()
        {

        }
        public void UpdateList()
        {
            // Should have ability to add more to list and overwrite existing items in list.
        }
        public void DeleteList()
        {

        }
    }
}
