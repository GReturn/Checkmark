using System;
using System.IO;

namespace Checkmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checkmark");

            if (!File.Exists(Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName)))
            {
                CheckmarkSetup.ShowSetupMenu();
            }
            while (true)
            {
                CheckmarkMenu.Run(Delete This When Testing);
            }
        }
    }
}