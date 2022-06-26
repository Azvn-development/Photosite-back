using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Photosite.BLL.Handlers;
using Photosite.BLL.Mapping;
using Photosite.Configuration.Options;
using Photosite.DAL;
using Photosite.DAL.Repositories.About;
using Photosite.DAL.Repositories.Service;
using Photosite.DAL.Repositories.User;
using System;

namespace Photosite.Test.Configuration
{
    public static class ServicesConfiguration
    {
        public static IServiceProvider GetServicesConfiguration(PhotositeContext dbContext, ConfigurationManager configuration)
        {
            IServiceCollection services = new ServiceCollection();

            services.Configure<AuthOptions>(configuration.GetSection(OptionSections.Auth));

            services.AddAutoMapper(typeof(AboutProfile));

            services.AddScoped(db => dbContext);
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();

            services.AddMediatR(typeof(IBaseHandler<,>).Assembly);

            return services.BuildServiceProvider();
        } // GetServicesConfiguration
    }
}
