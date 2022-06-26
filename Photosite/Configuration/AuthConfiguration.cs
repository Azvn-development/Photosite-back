using Microsoft.IdentityModel.Tokens;
using Photosite.Configuration.Options;

namespace Photosite.Configuration
{
    public static class AuthConfiguration
    {
        public static IServiceCollection AddAuthConfiguration(this IServiceCollection services, AuthOptions authOptions)
        {
            services
                .AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = authOptions.Issurer,
                        ValidateAudience = true,
                        ValidAudience = authOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = authOptions.GetSymmetricSecurityKey(),
                        RequireExpirationTime = false
                    };
                });

            return services;
        } // AddAuthConfiguration

        public static IApplicationBuilder UseAuthConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            return app;
        } // UseAuthConfiguration
    }
}
