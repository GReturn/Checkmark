using BetterConsoleTables;

namespace Checkmark.ConsoleUI.Utilities;

internal class TableCreator
{
    static internal void MakeListTable()
    {
        var list = CheckmarkPublicServices.ReadList();

        var table = new Table("Id", "Item", "Priority", "Status");

        // TODO: Make list into an array. Reiterate foreach() table.AddRow.

        table.AddRow(1, 2, 3, 4)
             .AddRow($"No ID system", $"{list.itemName}", $"{list.itemPriority}");

        Write(table.ToString());
        WriteLine();

        var rows = Enumerable.Repeat(new CheckmarkList(), 10);

        ConsoleTable
            .From<CheckmarkList>(rows)
            .Configure(o => o.NumberAlignment = Alignment.Right)
            .Write(Format.Alternative);
    }
}
