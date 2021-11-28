using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsScriptExecutionManager.Models
{
    public class ScriptModel
    {
        public string? FilePath { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Contents { get; set; }
    }
}
