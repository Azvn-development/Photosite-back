using FluentValidation.AspNetCore;
using Photosite.BLL.Handlers.Abouts.Validators;
using Photosite.BLL.Mapping;
using Photosite.DAL.Repositories.About;
using Photosite.DAL.Repositories.Service;
using Photosite.DAL.Repositories.User;

namespace Photosite.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AboutProfile));

            services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateAboutCommandValidator>());

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();

            return services;
        } // AddServicesConfiguration
    }
}
