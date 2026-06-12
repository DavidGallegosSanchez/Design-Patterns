using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class LogManager
    {

        // 1. Static instance wrapped in Lazy<T>. 
        // .NET natively guarantees that creation is Thread-Safe.
        private static readonly Lazy<LogManager> _instance =
            new Lazy<LogManager>(() => new LogManager());

        // 2. Global access point to the unique instance
        public static LogManager Instance => _instance.Value;

        private readonly string _logFilePath;

        // 3. Private constructor to prevent external instantiation
        private LogManager()
        {
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.log");
            Console.WriteLine("Initializing LogManager (Only one time)");
        }

        // Business method
        public void WriteLog(string message)
        {
            string logLine = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            // In production you would use file locks, this is for illustrative purposes only
            Console.WriteLine($"Writing in file: {logLine}");
        }
    }
}
