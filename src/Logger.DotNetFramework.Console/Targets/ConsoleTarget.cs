using Logger.Core.Abstractions;
using System;
using System.Threading.Tasks;

namespace Logger.Core.DotNet.WebAPI.Targets
{
    internal class ConsoleTarget : ITarget
    {
        public async Task WriteAsync(DateTime dateTime, string logMessage)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine($@"{currentTime}: {logMessage}");
            await Task.CompletedTask;
        }
    }
}
