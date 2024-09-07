using Logger.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logger.Core.Implementations
{
    public class ApplicationLogger : IApplicationLogger
    {
        private readonly IEnumerable<ITarget> _targets;

        public ApplicationLogger(IEnumerable<ITarget> targets)
        {
            _targets = targets;
        }

        #region IApplicationLogger Members
        public async Task WriteErrorAsync(string log)
        {
            await Write(Format("Error", log));
        }

        public async Task WriteErrorAsync(string log, Exception exception)
        {
            await Write(Format("Error", log, exception));
        }

        public async Task WriteInformationAsync(string log)
        {
            await Write(Format("Information", log));
        }

        public async Task WriteWarningAsync(string log)
        {
            await Write(Format("Warning", log));
        } 
        #endregion

        private static string Format(string level, string log, Exception exception = null)
        {
            string exceptionAsString = string.Empty;
            if (exception != null)
            {
                exceptionAsString = exception.ToString();
            }

            return $@"[{level}]: {log} {exceptionAsString}".Trim();
        }
        private async Task Write(string formattedLog)
        {
            List<Task> taskToExecute = new List<Task>();
            DateTime logDateTime = DateTime.Now;

            foreach (var target in _targets)
            {
                taskToExecute.Add(target.WriteAsync(logDateTime, formattedLog));
            };

            await Task.WhenAll(taskToExecute.ToArray());
        }
    }
}
