using ChainResponsibility.Interface;
using ChainResponsibility.Model;
using Microsoft.AspNetCore.Mvc;

namespace ChainResponsibility.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHandler _handler;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHandler handler)
        {
            _logger = logger;
            _handler = handler;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var validation = new ValidationRequest
            {
                Id = Guid.NewGuid(),
                Lastname = "",
                Name = "asd"
            };

            _handler.Handler(validation);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}