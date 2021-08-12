using System;
using System.IO;

namespace Checkmark
{
    public partial class UI
    {
        internal const string DIR = @"C:\Temp\Checkmark\TodoLists";
        internal const string PATH = @"TodoLists\my-lists.json";
        internal string pathToFileName = Path.Combine(DIR, PATH);
    }
}