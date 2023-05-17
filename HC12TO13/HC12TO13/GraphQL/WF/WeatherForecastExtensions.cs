using HotChocolate.Execution.Configuration;

namespace HC12TO13.GraphQL.WF
{
    public static class WeatherForecastExtensions
    {
        public static void AddWeatherForecastServices(this IServiceCollection services)
        {
            services.AddScoped<WeatherForecastResolver>();
        }


        public static IRequestExecutorBuilder AddWeatherForecastTypes(this IRequestExecutorBuilder executor)
        {
            executor
                .AddTypeExtension<WeatherForecastQuery>()
                .AddTypeExtension<WeatherForecastMutation>()
                .AddType<WeatherForecastObjectType>()
                .AddType<WeatherForecastInputObjectType>();

            return executor;
        }
    }
}
