using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Checkmark.Templates;

namespace Checkmark.Services
{
    class CheckmarkListServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        public static CheckmarkConfig GetCheckmarkConfig()
        {
            #region Get config file
            var configFile = string.Empty;
            var pathToFile = Path.Combine(CheckmarkConfig.CheckmarkConfigDirectory, CheckmarkConfig.CheckmarkConfigFileName);

            using (var fileString = File.OpenRead(pathToFile))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                configFile = streamReader.ReadToEnd();
            #endregion
            return JsonSerializer.Deserialize<CheckmarkConfig>(configFile, jsonSerializerOptions);
        }
        public static CheckmarkItem GetCheckmarkList() // TODO: Make async. Run before Sharprompt instance in CheckmarkView.cs
        {
            var checkmarkConfig = GetCheckmarkConfig();

            #region Get list file basing from config content
            var listJson = string.Empty;
            var configPath = Path.Combine(checkmarkConfig.DIR, checkmarkConfig.FILENAME);
            
            using (var fileString = File.OpenRead(configPath))
            using (var streamReader = new StreamReader(fileString, new UTF8Encoding(false)))
                listJson = streamReader.ReadToEnd();
            #endregion
            return JsonSerializer.Deserialize<CheckmarkItem>(listJson);
        }


        /* 
         * Add here merged CheckmarkFileServices.cs and CheckmarkJsonServices.cs
         * 
         * Methods must be relating to list services such as
         * GetCheckmarkListFromPath()
         * 
         * use regions if you decide to separate JSON services.
        */
    
    }
}
