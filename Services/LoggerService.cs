using System;
using System.Threading.Tasks;
using Module5HW1.Models;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services
{
    public class LoggerService : ILoggerService
    {
        private IConsoleNotificator _consoleNotificator;

        public LoggerService(IConsoleNotificator consoleNotificator)
        {
            _consoleNotificator = consoleNotificator;
        }

        public async Task WriteLogAsync(LogType type, string text)
        {
            await Task.Run(() => _consoleNotificator.Notify($"{DateTime.UtcNow} - {type} - {text}"));
        }

        public async Task LogErrorAsync(string message)
        {
            await WriteLogAsync(LogType.Error, message);
        }

        public async Task LogInfoAsync(string message)
        {
            await WriteLogAsync(LogType.Info, message);
        }

        public async Task LogWarningAsync(string message)
        {
            await WriteLogAsync(LogType.Warning, message);
        }
    }
}
