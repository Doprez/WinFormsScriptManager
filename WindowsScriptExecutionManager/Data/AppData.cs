using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsScriptExecutionManager.Models.ApplicationModels;
using WindowsScriptExecutionManager.Utils;

namespace WindowsScriptExecutionManager.Data
{
    public class AppData
    {

        public AppSettingsModel? AppSettings { get; set; }
        public string DefaultSettingsPath = Application.StartupPath + "Settings.json";

        public AppSettingsModel GetSettings(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                file = DefaultSettingsPath;
            }
            if (File.Exists(file))
            {
                using (StreamReader r = new StreamReader(file))
                {
                    AppSettings = JsonHelper.DeserializeJson<AppSettingsModel>(r.ReadToEnd());
                }
            }
            else
            {
                using (StreamWriter write = new StreamWriter(file))
                {
                    var result = JsonHelper.SerializeJson(new AppSettingsModel { LocalScriptsFolder = Application.StartupPath + "Scripts" });
                    write.Write(result);
                }
            }
            return AppSettings;
        }

    }
}
