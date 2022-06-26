using MediatR;
using Photosite.BLL.Handlers;
using Photosite.Configuration.Behaviors;

namespace Photosite.Configuration
{
    public static class MediatrConfiguration
    {
        public static IServiceCollection AddMediatrConfiguration(this IServiceCollection services)
        {
            services.AddMediatR(typeof(IBaseHandler<,>).Assembly);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        } // AddMediatrConfiguration
    }
}
