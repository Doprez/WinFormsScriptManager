using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsScriptExecutionManager.Models
{
    public class CommandModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ProgramToRun { get;set; }
        public string? Arguments { get; set; }
    }
}
