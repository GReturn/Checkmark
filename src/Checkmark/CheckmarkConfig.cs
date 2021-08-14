using System.IO;

namespace Checkmark
{
    public class CheckmarkConfig
    {
        public static string Directory { get; } = "/LocalStorage/";
        public static string Filename { get; } = "checkmark-config.json";
        public static string PATH { get; } = Path.Combine(Directory, Filename);
    }
}
