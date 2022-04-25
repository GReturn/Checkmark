﻿namespace Checkmark.Services;

internal class CheckmarkAddToListServices
{
    static internal void AddToList(CheckmarkListTemplate list)
    {
        var json = CheckmarkJsonServices.Serialize(list);
        var checkmarkConfig = CheckmarkListServices.GetCheckmarkConfig();
        CheckmarkJsonServices.WriteToJsonFile(checkmarkConfig.DIR, checkmarkConfig.FILENAME, json);
    }
}