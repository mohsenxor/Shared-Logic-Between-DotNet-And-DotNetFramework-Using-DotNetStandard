using Logger.Core.Abstractions;
using Logger.Core.DotNet.WebAPI.Targets;
using Logger.Core.Implementations;
using System;

namespace Logger.DotNetFramework.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget[] targets = { new ConsoleTarget() };
            IApplicationLogger applicationLogger = new ApplicationLogger(targets);
            
            
            applicationLogger.WriteInformationAsync("This is an information log.");
            applicationLogger.WriteWarningAsync("This is a warning log.");
            applicationLogger.WriteErrorAsync("This is an Error log.");
            applicationLogger.WriteErrorAsync("This is an Error log.", new ApplicationException("Application exception log details."));

            System.Console.ReadKey();
        }
    }
}
