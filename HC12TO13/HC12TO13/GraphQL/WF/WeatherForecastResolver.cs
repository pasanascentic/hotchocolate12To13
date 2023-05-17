using HC12TO13.Services;

namespace HC12TO13.GraphQL.WF
{
    public class WeatherForecastResolver
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public WeatherForecastResolver(
            IWeatherForecastServices weatherForecastServices)
        {
            _weatherForecastServices = weatherForecastServices;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            return _weatherForecastServices.Get();
        }
    }
}
