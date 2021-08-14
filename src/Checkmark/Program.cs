using System;
using System.IO;

namespace Checkmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checkmark");

            if (!File.Exists(CheckmarkConfig.CheckmarkConfigPath))
            {
                CheckmarkSetup.ShowSetupMenu();
            }
            while (true)
            {
                CheckmarkMenu.Run();
            }
        }
    }
}