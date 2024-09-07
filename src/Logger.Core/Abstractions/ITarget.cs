using System;
using System.Threading.Tasks;

namespace Logger.Core.Abstractions
{
    public interface ITarget
    {
        Task WriteAsync(DateTime dateTime, string logMessage);
    }
}
