using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsScriptExecutionManager.Data;
using WindowsScriptExecutionManager.Models;
using WindowsScriptExecutionManager.Utils;

namespace WindowsScriptExecutionManager.Controllers
{
    public class ScriptController
    {
        private ScriptData _scriptData = new ScriptData();

        public ProcessOutputModel RunScript(string applicationToRun, string filePath)
        {
            return RunProgramCommand.RunCommand(applicationToRun, filePath).Result;
        }

        public List<ScriptModel> GetScripts()
        {
            return _scriptData.GetAvailableScripts();
        }

        public ScriptModel GetScript(string filePath)
        {
            return _scriptData.LoadScript(filePath);
        }

        public bool SaveScript(ScriptModel scriptToSave)
        {
            return _scriptData.SaveScript(scriptToSave);
        }
    }
}
