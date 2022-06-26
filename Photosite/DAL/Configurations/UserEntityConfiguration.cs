using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Photosite.DAL.Entities;

namespace Photosite.DAL.Configurations
{
    public class UserEntityConfiguration: IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasData(new List<UserEntity> 
            {
                new UserEntity { Id = 1, Login = "prAdmin", Password = "P12346_r?" }
            });
        } // Configure
    }
}
