using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsScriptExecutionManager.Utils
{
    public static class JsonHelper
    {
        private static readonly JsonSerializerOptions _options;

        static JsonHelper()
        {
            _options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
        }

        public static string SerializeJson<T>(T objectToSerialize)
        {
            return JsonSerializer.Serialize(objectToSerialize, _options);
        }

        public static T DeserializeJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, _options);
        }

    }
}
