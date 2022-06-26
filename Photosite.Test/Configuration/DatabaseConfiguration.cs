using Microsoft.EntityFrameworkCore;
using Photosite.DAL;

namespace Photosite.Test.Configuration
{
    public static class DatabaseConfiguration
    {
        public static PhotositeContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<PhotositeContext>()
             .UseInMemoryDatabase(databaseName: "photosite")
             .Options;

            return new PhotositeContext(options);
        }
    }
}
