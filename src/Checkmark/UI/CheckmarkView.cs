using Checkmark.Services;
using Checkmark.Templates;

using ConsoleTables;

using Sharprompt;

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

        private static ConsoleTable MakeListTable(CheckmarkList list)
        {
            var table = new ConsoleTable("Id", "Item", "Priority", "Status");

            // TODO: Make list into an array. Reiterate foreach() table.AddRow.

            table.AddRow(null, $"{list.TodoItem}", $"{list.Priority}", $"{list.Status}");

            return table;
            //WriteLine();

            //var rows = Enumerable.Repeat(new CheckmarkList(), 10);

            //ConsoleTable
            //    .From<CheckmarkList>(rows)
            //    .Configure(o => o.NumberAlignment = Alignment.Right)
            //    .Write(Format.Alternative);
        }
    }
}