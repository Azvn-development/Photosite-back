using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Photosite.DAL
{
    public class PhotositeContext: DbContext
    {
        public PhotositeContext(DbContextOptions<PhotositeContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(PhotositeContext)));
        }
    }
}
