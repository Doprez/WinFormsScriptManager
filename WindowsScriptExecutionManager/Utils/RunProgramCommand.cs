using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsScriptExecutionManager.Models;

namespace WindowsScriptExecutionManager.Utils
{
    public static class RunProgramCommand
    {
        public static async Task<ProcessOutputModel> RunCommand(string application, string args)
        {
            try
            {
                ProcessOutputModel output = new ProcessOutputModel();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = application;
                startInfo.Arguments = "/C " + args;

                process.StartInfo = startInfo;
                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    output.Output += process.StandardOutput.ReadLineAsync().Result + "\n";
                }
                output.OutputCode = process.ExitCode;

                return await Task.FromResult(output);
            }
            catch (Exception exception)
            {
                return new ProcessOutputModel { Error = exception.Message, OutputCode = 1 };
                //logging needed
            }
        }
    }
}
