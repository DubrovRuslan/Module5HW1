using System;
using Module5HW1.Services.Abstractions;

namespace Module5HW1.Services
{
    public class ConsoleNotificator : IConsoleNotificator
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
