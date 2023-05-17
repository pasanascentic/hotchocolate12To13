using HC12TO13.GraphQL.WF;

namespace HC12TO13.GraphQL
{
    public static class ServiceExtensions
    {
        public static void AddWFGraphQLServer(this IServiceCollection services)
        {
            services.AddWeatherForecastServices();

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddWeatherForecastTypes();
        }

        public static void MapWFGraphQL(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGraphQL();
        }
    }
}
