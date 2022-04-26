namespace Checkmark;

public class CheckmarkSetup
{
    // This one sets up DIRECTORY and specifies where to place future items in list
    public static void AddDirectory(string inputDirectory)
    {
        inputDirectory += @"\Checkmark\";
        var checkmarkConfig = new CheckmarkConfig
        {
            DIR = inputDirectory
        };
        var json = CheckmarkJsonServices.SerializeConfig(checkmarkConfig);
        
        CheckmarkJsonServices.WriteToJsonFile(CheckmarkConfig.CheckmarkConfigDirectory,
                                            CheckmarkConfig.CheckmarkConfigFileName,
                                            json);
    }
    public static bool CheckForConfig()
    {
        return CheckmarkConfig.CheckForConfig();
    }
}