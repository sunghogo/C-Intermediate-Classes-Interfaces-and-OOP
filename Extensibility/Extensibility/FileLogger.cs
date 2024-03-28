using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogInfo(string message)
        {
            Log(message, LogType.INFO);
        }

        public void LogError(string message)
        {
            Log(message, LogType.ERROR);
        }

        private void Log(string message, LogType logType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{logType}: {message}");
                //streamWriter.Dispose(); // Frees up resoures not used by CLR
            }
        }
    }
}
