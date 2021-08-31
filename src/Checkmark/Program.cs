﻿using System;

using Microsoft.Extensions.DependencyInjection;

using Sharprompt;

using Checkmark.Handlers;

using static System.Console;

namespace Checkmark
{
    static internal class Program
    {
        private static void Main()
        {
            var services = ConfigureServices();
            var provider = services.BuildServiceProvider();

            InteractiveMode(provider);
        }

        private static void InteractiveMode(ServiceProvider provider)
        {
            WriteLine("Welcome to Checkmark!");

            var command = Prompt.Select("What do you wish to do?",
            new[]
            {
                "Add new item to list",
                "Read my list",
                "Delete an item",
                "Exit application"
            });
            HandleCommand(provider, command);
        }

        private static void HandleCommand(ServiceProvider provider, string command)
        {
            switch (command)
            {
                case "Add new item to list":
                    provider.GetRequiredService<AddItemHandler>();
                    break;

                case "Read my list":
                    WriteLine("Reading");
                    break;

                case "Delete an item":
                    WriteLine("Deleting");
                    break;

                case "Exit application":
                    Environment.Exit(0);
                    break;
            }
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<AddItemHandler>();

            return services;
        }
    }
}