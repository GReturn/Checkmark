using System;
namespace Checkmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checkmark");
            Setup.ShowSetupMenu();

            while (true)
            {
                CheckmarkMenu.Run();
            }
        }
    }
}