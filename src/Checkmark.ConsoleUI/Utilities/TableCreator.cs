using BetterConsoleTables;

namespace Checkmark.ConsoleUI.Utilities;

internal class TableCreator
{
    static internal void MakeListTable()
    {
        var list = ReadList();

        var tableHeaders = new[]
        {
            new ColumnHeader("Item Name", Alignment.Center),
            new ColumnHeader("Priority Level", Alignment.Center)
        };
        var table = new Table(tableHeaders);

        foreach (var item in list)
        {
            table.AddRow(item.TodoItem, item.Priority);
        }
        table.Config = TableConfiguration.Unicode();

        WriteLine(table.ToString());
    }
}
