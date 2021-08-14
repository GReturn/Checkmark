using System;
namespace Checkmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Checkmark");

            while (true)
            {
                CheckmarkMenu.Run();
            }
        }
    }
}