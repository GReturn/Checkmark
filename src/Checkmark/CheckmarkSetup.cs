namespace Checkmark;

public class CheckmarkSetup
{
    public static bool CheckForConfig()
    {
        if (File.Exists(Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory,
                                         CheckmarkConfig.CheckmarkConfigFileName)))
        {
            return true;
        }
        return false;
    }

    public static void AddDirectory(string inputDirectory)
    {
        inputDirectory += @"\Checkmark\";

        var checkmarkConfig = new CheckmarkConfig
        {
            DIR = inputDirectory
        };
        var json = CheckmarkJsonServices.Serialize(checkmarkConfig);

        CheckmarkJsonServices.CreateJsonFile(CheckmarkConfig.CheckmarkConfigDirectory,
                                            CheckmarkConfig.CheckmarkConfigFileName,
                                            json);
    }
}
