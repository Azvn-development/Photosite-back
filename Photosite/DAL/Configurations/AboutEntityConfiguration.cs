using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Configurations
{
    public class AboutEntityConfiguration : IEntityTypeConfiguration<AboutEntity>
    {
        public void Configure(EntityTypeBuilder<AboutEntity> builder)
        {
            builder.ToTable("Abouts");

            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Text).IsRequired();
        } // Configure
    }
}
