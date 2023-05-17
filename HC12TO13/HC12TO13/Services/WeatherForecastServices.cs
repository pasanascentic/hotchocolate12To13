namespace HC12TO13.Services
{
    public interface IWeatherForecastServices
    {
        IEnumerable<WeatherForecast> Get();

        WeatherForecast Post(WeatherForecast weatherForecast);
    }

    public class WeatherForecastServices : IWeatherForecastServices
    {
        private static List<WeatherForecast> weatherForecasts = new List<WeatherForecast>(new[]
        {
            new WeatherForecast
            {
                Date = DateTime.UtcNow,
                Summary = "Freezing",
                TemperatureC = 0,
            },
            new WeatherForecast
            {
                Date = DateTime.UtcNow,
                Summary = "Bracing",
                TemperatureC = 6
            },
            new WeatherForecast
            {
                Date = DateTime.UtcNow,
                Summary = "Chilly",
                TemperatureC = 8
            }
            //"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        });

        public IEnumerable<WeatherForecast> Get()
        {
            return weatherForecasts;
        }

        public WeatherForecast Post(WeatherForecast weatherForecast)
        {
            weatherForecasts.Add(weatherForecast);

            return weatherForecast;
        }
    }
}
