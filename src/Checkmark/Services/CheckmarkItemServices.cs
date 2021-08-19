/*
 * This class provides services specific to a Checkmark list.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using Checkmark.Templates;

namespace Checkmark.Services
{
    public class CheckmarkItemServices
    {
        // TODO: 
        public static int CreateItemId()
        {
            // check for existing IDs
            // create new ID.



            return 1;
        }
        public static void CreateTableFromList()
        {
            var checkmarkList = new CheckmarkItem();

            var table = new ConsoleTable("Id", "Item Name", "Priority");
            table.AddRow(1, 2, 3)
                 .AddRow("this line should be longer", "yes it is", "oh");

            table.Write();
            Console.WriteLine();

            var rows = Enumerable.Repeat(new Something(), 10);

            ConsoleTable
                .From<Something>(rows)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);

            Console.ReadKey();
        }
    }
}
