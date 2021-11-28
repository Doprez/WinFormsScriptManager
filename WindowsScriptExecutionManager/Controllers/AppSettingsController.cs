using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsScriptExecutionManager.Data;
using WindowsScriptExecutionManager.Models.ApplicationModels;
using WindowsScriptExecutionManager.Utils;

namespace WindowsScriptExecutionManager.Controllers
{
    public class AppSettingsController
    {
        AppData AppData = new AppData();

        public AppSettingsModel LoadSettings()
        {
            return AppData.GetSettings("");
        }

        public AppSettingsModel LoadSettings(string filePath)
        {
            return AppData.GetSettings(filePath);
        }

        public void UpdateSettings(AppSettingsModel appSettings)
        {
            JsonHelper.SerializeJson(appSettings);
        }

    }
}
