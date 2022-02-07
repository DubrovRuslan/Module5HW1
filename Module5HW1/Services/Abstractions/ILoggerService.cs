using System.Threading.Tasks;
using Module5HW1.Models;

namespace Module5HW1.Services.Abstractions
{
    public interface ILoggerService
    {
        public Task LogErrorAsync(string message);
        public Task LogInfoAsync(string message);
        public Task LogWarningAsync(string message);
    }
}
