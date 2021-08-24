/*
 * This class provides JSON (JavaSctipt Object Notation) de/serialization services.
 */

using System.Text.Json;
using Checkmark.Templates;
using System.Collections;

namespace Checkmark.Services
{
    public class CheckmarkJsonServices
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
        };

        #region JSON services for the user's Checkmark list
        public static string Serialize(CheckmarkList json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        #endregion

        #region JSON services for Checkmark files configuration
        public static string Serialize(CheckmarkConfig json)
        {
            return JsonSerializer.Serialize(json, jsonSerializerOptions);
        }
        #endregion
    }
}
