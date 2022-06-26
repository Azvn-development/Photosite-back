using Photosite.Configuration.Options;

namespace Photosite.Configuration
{
    public static class OptionsConfiguration
    {
        public static IServiceCollection AddOptionsConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AuthOptions>(configuration.GetSection(OptionSections.Auth));

            return services;
        } // AddOptionsConfiguration
    }
}
