namespace Photosite.Configuration
{
    public static class FilesConfiguration
    {
        public static IApplicationBuilder UseFilesConfiguration(this IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            return app;
        } // UseFilesConfiguration
    }
}
