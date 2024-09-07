using System;
using System.Threading.Tasks;

namespace Logger.Core.Abstractions
{
    public interface IApplicationLogger
    {
        Task WriteInformationAsync(string log);
        Task WriteWarningAsync(string log);
        Task WriteErrorAsync(string log);
        Task WriteErrorAsync(string log, Exception exception);
    }
}
