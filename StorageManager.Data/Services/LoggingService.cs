using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace StorageManager.Data.Services
{
    public class LoggingService
    {
        private readonly string _logFilePath;

        public LoggingService(string logFilePath = "logs.txt")
        {
            _logFilePath = logFilePath;
            EnsureLogFileExists();
        }

        private void EnsureLogFileExists()
        {
            if (!File.Exists(_logFilePath))
            {
                File.Create(_logFilePath).Close();
            }
        }

        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] - {message}{Environment.NewLine}";
            File.AppendAllText(_logFilePath, logEntry);
        }

        public enum LogLevel
        {
            Info,
            Warning,
            Error
        }
    }
}