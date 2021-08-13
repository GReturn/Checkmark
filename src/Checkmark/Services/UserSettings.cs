using System.IO;

namespace Checkmark.Services
{
    class UserSettings
    {
        internal const string DIR = @"C:\Temp\Checkmark\TodoLists";
        internal const string PATH = @"TodoLists\my-lists.json";
        internal string pathToFileName = Path.Combine(DIR, PATH);
        private void CreateSettings()
        {

        }
    }
}
