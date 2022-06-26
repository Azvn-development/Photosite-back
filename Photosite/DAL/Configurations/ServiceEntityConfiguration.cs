using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Configurations
{
    public class ServiceEntityConfiguration : IEntityTypeConfiguration<ServiceEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceEntity> builder)
        {
            builder.ToTable("Services");

            builder.Property(x => x.Name).IsRequired();
        } // Configure
    }
}
