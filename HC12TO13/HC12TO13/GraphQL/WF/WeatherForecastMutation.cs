using HC12TO13.Services;
using Microsoft.AspNetCore.Authorization;

namespace HC12TO13.GraphQL.WF
{
    [ExtendObjectType(typeof(Mutation))]
    public class WeatherForecastMutation
    {
        private readonly IWeatherForecastServices _weatherForecastServices;

        public WeatherForecastMutation(IWeatherForecastServices weatherForecastServices)
        {
            _weatherForecastServices = weatherForecastServices;
        }

        [GraphQLDescription("Create weather Forecast")]
        public WeatherForecast CreateWeatherForecast(WeatherForecast weatherForecast)
        {
            return _weatherForecastServices.Post(weatherForecast);
        }
    }
}
