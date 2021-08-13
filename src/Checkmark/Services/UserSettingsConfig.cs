using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Checkmark.Services
{
    public class UserSettingsConfig
    {
        [JsonPropertyName("Directory")]
        public string DIR { get; private set; }
        [JsonPropertyName("Path")]
        public string PATH { get; private set; }
        
        //public UserSettings(string directory, string path)
        //{
        //    DIR = directory;
        //    PATH = path;
        //    //string pathToFileName = Path.Combine(DIR, PATH);
        //}
        //private bool DoesUserDirectoryExists(string directory)
        //{
        //    if (Directory.Exists(directory))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //private static UserSettings DeserializeUserSettingsJson(string jsonUserSettingsFile)
        //{
        //    return JsonSerializer.Deserialize<UserSettings>(jsonUserSettingsFile);
        //}
    }
}
