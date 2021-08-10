using Checkmark.Interfaces;
namespace Checkmark
{
    public partial class Options : IOptions
    {
        public void ViewList()
        {
            System.Console.WriteLine(PATH);
        }
    }
}