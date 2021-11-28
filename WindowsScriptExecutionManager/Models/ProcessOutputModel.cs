using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsScriptExecutionManager.Models
{
    public class ProcessOutputModel
    {
        public string? Output { get; set; }
        public int OutputCode { get; set; }
        public string? Error { get; set; }
    }
}
