namespace Checkmark;

public class CheckmarkSetup
{
    // Set-up DIRECTORY and specify where to place future todos
    public static void AddDirectory(string inputDirectory)
    {
        inputDirectory += @"\Checkmark\";
        var checkmarkConfig = new CheckmarkConfig
        {
            DIR = inputDirectory
        };
        var json = CheckmarkJsonServices.Serialize(checkmarkConfig);
        
        CheckmarkJsonServices.WriteToJsonFile(CheckmarkConfig.CheckmarkConfigDirectory,
                                            CheckmarkConfig.CheckmarkConfigFileName,
                                            json);
    }
    public static bool CheckForConfig()
    {
        return CheckmarkConfigServices.CheckForConfig();
    }
}