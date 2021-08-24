using Sharprompt;
using static System.Console;
using Checkmark.Services;
using Checkmark.Templates;
using ConsoleTables;
using System.Linq;

namespace Checkmark.UI
{
    static internal class CheckmarkView
    {
        public static void ShowViewMenu()
        {
            var viewListChoice = Prompt.Select("How do you want to view your lists?",
                new[] {
                    "In a table"
                });
            var list = CheckmarkMainServices.ReadList();
            MakeListTable(list);

        }
        private static void MakeListTable(CheckmarkList list)
        {
            var table = new ConsoleTable("Id", "Item", "Priority", "Status");

            // TODO: Make list into an array. Reiterate foreach() table.AddRow.

            table.AddRow(1, 2, 3, 4)
                 .AddRow($"No ID system", $"{list.TodoItem}", $"{list.Priority}", $"{list.Status}");

            table.Write();
            WriteLine();

            var rows = Enumerable.Repeat(new CheckmarkList(), 10);

            ConsoleTable
                .From<CheckmarkList>(rows)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);
        }
    }
}
