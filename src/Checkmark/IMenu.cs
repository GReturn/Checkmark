using Microsoft.Extensions.DependencyInjection;

namespace Checkmark
{
    internal interface IMenu
    {
        IServiceCollection ConfigureServices();

        void InteractiveMode();
    }
}
