using Photosite.Configuration;
using Photosite.Configuration.Options;
using EnvironmentName = Microsoft.AspNetCore.Hosting.EnvironmentName;

// Services configuration
var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile(builder.Environment.EnvironmentName == EnvironmentName.Development ? "appsettings.Development.json" : "appsettings.json");
builder.Services.AddOptionsConfiguration(builder.Configuration);
builder.Services.AddControllersConfiguration();
builder.Services.AddCorsConfiguration();
builder.Services.AddAuthConfiguration(builder.Configuration.GetSection(OptionSections.Auth).Get<AuthOptions>());
builder.Services.AddSwaggerConfiguration();
builder.Services.AddDatabaseConfiguration(builder.Configuration.GetSection(OptionSections.Database).Get<DatabaseOptions>());
builder.Services.AddMediatrConfiguration();
builder.Services.AddServicesConfiguration();

// Application configuration
var app = builder.Build();
app.UseCorsConfiguration(builder.Configuration.GetSection(OptionSections.CORS).Get<CorsOptions>());
app.UseFilesConfiguration();
app.UseSwaggerConfiguration();
app.UseRouting();
app.UseAuthConfiguration();
app.UseEndpoints(edpoints =>
{
    edpoints.MapControllers();
});

app.Run();
