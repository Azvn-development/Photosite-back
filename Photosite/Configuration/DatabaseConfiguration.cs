using Photosite.Configuration.Options;
using Microsoft.EntityFrameworkCore;
using Photosite.DAL;

namespace Photosite.Configuration
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, DatabaseOptions databaseOptions)
        {
            services.AddDbContext<PhotositeContext>(options => options.UseNpgsql(databaseOptions.ConnectionString));

            return services;
        } // AddDatabaseConfiguration

        public static IApplicationBuilder UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            var scope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();

            using var context = scope.ServiceProvider.GetRequiredService<PhotositeContext>();
            context.Database.Migrate();

            return app;
        } // UseDatabaseConfiguration
    }
}
