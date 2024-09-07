using Logger.Core.Abstractions;

namespace Logger.DotNetCore.WebApi.Targets
{
    public class FileTarget : ITarget
    {
        public async Task WriteAsync(DateTime dateTime, string logMessage)
        {
            string currentDate = dateTime.ToString("yyyy-MM-dd");

            string logFileName = $"{currentDate}.txt";

            using (StreamWriter writer = new StreamWriter(logFileName, true))
            {
                await writer.WriteLineAsync(logMessage);
            }
        }
    }
}