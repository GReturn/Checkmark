namespace Checkmark;

public class CheckmarkSetup
{
    // Set-up DIRECTORY and specify where to place future lists
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