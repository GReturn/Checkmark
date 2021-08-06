using System;
using static System.Console;
using Sharprompt;

namespace Checkmark
{ 
    public class CheckmarkMenu
    {
        private const string prefix = ">>"; 
        public static void Run()
        {
            while(true)
            {    
                ShowMenu();
            }
        }
        private static void ShowMenu()
        {
            Write(prefix);

            WriteLine(" Welcome.");
            
            var input = Prompt.Select("What do you wish to do?", new[] { "Create", "Read", "Update" });
            
            switch(input.ToUpper())
            {
                case "CREATE":
                    WriteLine("Creating...");
                    break;
                case "READ":
                    WriteLine("Reading...");
                    break;
                case "UPDATE": 
                    Environment.Exit(0);
                    break;
                case "DELETE":
                    WriteLine("Error...");
                    break;
            }
            Environment.Exit(0);
        }
    }
}