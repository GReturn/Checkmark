using System;
using System.IO;

namespace Checkmark
{
    static internal class Program
    {
        private static void Main()
        {
            var config = new CheckmarkConfig();

            Console.WriteLine("Welcome to Checkmark");

            if (!File.Exists(Path.Combine(config.Directory, config.FileName)))
            {
                CheckmarkSetup.InteractiveMode();
            }
            while (true)
            {
                CheckmarkMenu.Run();
            }
        }
    }
}