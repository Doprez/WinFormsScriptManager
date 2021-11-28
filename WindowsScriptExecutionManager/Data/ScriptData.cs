using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using WindowsScriptExecutionManager.Controllers;
using WindowsScriptExecutionManager.Models.ApplicationModels;
using WindowsScriptExecutionManager.Models;
using WindowsScriptExecutionManager.Utils;

namespace WindowsScriptExecutionManager.Data
{
    public class ScriptData
    {
        private AppSettingsController _appSettingsController = new AppSettingsController();
        private AppSettingsModel _appSettings;

        public ScriptData()
        {
            _appSettings = _appSettingsController.LoadSettings();
        }

        public List<ScriptModel> GetAvailableScripts()
        {
            List<ScriptModel> scripts = new List<ScriptModel>();
            if (Directory.Exists(_appSettings.LocalScriptsFolder))
            {
                Directory.CreateDirectory(_appSettings.LocalScriptsFolder);
                var files = Directory.GetFiles(_appSettings.LocalScriptsFolder);
                
                foreach (var file in files)
                {
                    scripts.Add(new ScriptModel { FilePath = file, Name = file.Replace(_appSettings.LocalScriptsFolder + "\\", "") });
                }
            }

            return scripts;
        }

        public ScriptModel LoadScript(string filePath)
        {
            var script = new ScriptModel();

            if (File.Exists(filePath))
            {
                script.FilePath = filePath;
                script.Name = filePath;
                script.Contents = File.ReadAllText(filePath);
            }

            return script;
        }

        public bool SaveScript(ScriptModel scriptToSave)
        {
            using (StreamWriter writer = new StreamWriter(scriptToSave.FilePath))
            {
                writer.Write(scriptToSave.Contents);
            }

            return true;
        }

    }
}
