using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models
{
    public class FileLogger : ILogger
    {
        private string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log("Error", message);
            
        }

        public void LogInfo(string message)
        {
            Log("Info", message);
        }

        private void Log(string message, string messageType) 
        {
            using (var stream = new StreamWriter(_path, true, Encoding.UTF8))
            {
                stream.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
