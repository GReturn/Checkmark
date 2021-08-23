/*
 * This class provides file management services. 
 * Content may seem conflicted with CheckmarkJsonServices.cs,
 * but you should know that codes can experience
 * existential crises too! #CodeMentalHealthAwareness <3
 */

using System.IO;
using System.Text;
using System.Threading.Tasks;
using Checkmark.Templates;

namespace Checkmark.Services
{
    public static class CheckmarkFileServices
    {
        public static void CreateJsonFile(string directory, string filename, string json)
        {
            var pathToFile = Path.Combine(directory, filename);
            Directory.CreateDirectory(directory);

            if(Directory.Exists(directory))
            {
                File.WriteAllText(pathToFile, json);
            }
        }
    }
}
