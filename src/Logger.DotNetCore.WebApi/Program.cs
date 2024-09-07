using Logger.Core.Abstractions;
using Logger.Core.Implementations;
using Logger.DotNetCore.WebApi.Targets;
using System.Threading.Tasks.Dataflow;

namespace Logger.DotNetCore.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSingleton<ITarget, FileTarget>();
            builder.Services.AddSingleton<IApplicationLogger, ApplicationLogger>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
