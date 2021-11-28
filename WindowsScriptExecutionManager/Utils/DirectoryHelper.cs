using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsScriptExecutionManager.Utils
{
    public static class DirectoryHelper
    {
        public static List<DirectoryModel> Directories = new List<DirectoryModel>();

        public static List<DirectoryModel> GetDirectories(string directoryPath = "")
        {
            Directories = new List<DirectoryModel>();

            var root = Path.GetPathRoot(Directory.GetCurrentDirectory());

            var directories = Directory.GetDirectories(string.IsNullOrWhiteSpace(directoryPath) ? root : directoryPath);

            Directories.Add(new DirectoryModel
            {
                Name = "..",
                FullName = "..",
            });

            foreach (var directory in directories)
            {
                var dir = new DirectoryInfo(directory);
                Directories.Add(new DirectoryModel
                {
                    Name = dir.Name,
                    FullName = dir.FullName,
                });
            }

            return Directories;
        }
    }

    public class DirectoryModel
    {
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
    }
}
