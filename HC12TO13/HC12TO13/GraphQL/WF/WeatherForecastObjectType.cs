namespace HC12TO13.GraphQL.WF
{
    public class WeatherForecastObjectType : ObjectType<WeatherForecast>
    {
        protected override void Configure(IObjectTypeDescriptor<WeatherForecast> descriptor)
        {
        }
    }
    public class WeatherForecastInputObjectType : InputObjectType<WeatherForecast>
    {
        protected override void Configure(IInputObjectTypeDescriptor<WeatherForecast> descriptor)
        {
        }
    }

}
