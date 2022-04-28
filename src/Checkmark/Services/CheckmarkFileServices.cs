using System.Text;

namespace Checkmark.Services;

internal class CheckmarkFileServices
{
    static internal string GetConfigFileData()
    {
        var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory,
                                            CheckmarkConfig.CheckmarkConfigFileName);

        using var fileString = File.OpenRead(pathToFile);
        using var streamReader = new StreamReader(fileString,
                                           new UTF8Encoding(false));
        return streamReader.ReadToEnd();
    }
    static internal string GetListDataFromConfigFile(CheckmarkConfig checkmarkConfig)
    {
        var configPath = Path.Combine(checkmarkConfig.DIR,
                                            checkmarkConfig.FILENAME);

        using var fileString = File.OpenRead(configPath);
        using var streamReader = new StreamReader(fileString,
                                        new UTF8Encoding(false));
        return streamReader.ReadToEnd();
    }
    static internal bool CheckForExistingListFile()
    {
        var configData = CheckmarkListServices.GetCheckmarkConfig();

        if (File.Exists(Path.Combine(configData.DIR,
                                         configData.FILENAME)))
        {
            return true;
        }
        return false;
    }
}
