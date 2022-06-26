using Photosite.Configuration.Options;

namespace Photosite.Configuration
{
    public static class CorsConfiguration
    {
        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors();

            return services;
        } // AddCorsConfiguration

        public static IApplicationBuilder UseCorsConfiguration(this IApplicationBuilder app, CorsOptions corsOptions)
        {
            app.UseCors(options =>
            {
                options
                    .WithOrigins(corsOptions.Origins)
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader();
            });

            return app;
        } // UseCorsConfiguration
    }
}
