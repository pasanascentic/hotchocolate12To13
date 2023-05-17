namespace HC12TO13.GraphQL.WF
{
    [ExtendObjectType(typeof(Query))]
    public class WeatherForecastQuery
    {
        [GraphQLDescription("Get weather forecast")]
        public IEnumerable<WeatherForecast> GetWeatherForecast([Service] WeatherForecastResolver resolver)
        {
            return resolver.GetWeatherForecast();
        }
    }
}
