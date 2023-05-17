using HC12TO13.Services;
using Microsoft.AspNetCore.Mvc;

namespace HC12TO13.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherForecastServices _weatherForecastServices;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecastServices weatherForecastServices)
        {
            _logger = logger;
            _weatherForecastServices = weatherForecastServices;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastServices.Get();
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public WeatherForecast Post(WeatherForecast weatherForecast)
        {
            return _weatherForecastServices.Post(weatherForecast);
        }
    }
}