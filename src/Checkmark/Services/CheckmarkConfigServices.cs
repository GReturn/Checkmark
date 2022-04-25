namespace Checkmark.Services;

internal class CheckmarkConfigServices
{
    static internal bool CheckForConfig()
    {
        if (File.Exists(Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory,
                                         CheckmarkConfig.CheckmarkConfigFileName)))
        {
            return true;
        }
        else return false;
    }
}
