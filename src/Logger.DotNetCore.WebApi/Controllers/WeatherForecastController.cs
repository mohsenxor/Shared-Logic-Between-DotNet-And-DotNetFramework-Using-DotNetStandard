using Logger.Core.Abstractions;
using Logger.Core.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Logger.DotNetCore.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IApplicationLogger _iApplicationLogger;
        private readonly IApplicationLogger _applicationLogger;

        public WeatherForecastController(IApplicationLogger applicationLogger)
        {
            _applicationLogger = applicationLogger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _applicationLogger.WriteInformationAsync("This is an information log.");
            _applicationLogger.WriteWarningAsync("This is a warning log.");
            _applicationLogger.WriteErrorAsync("This is an Error log.");
            _applicationLogger.WriteErrorAsync("This is an Error log.", new ApplicationException("Application exception log details."));

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
