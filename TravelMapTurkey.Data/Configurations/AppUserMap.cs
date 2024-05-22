using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Configurations
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x => x.LastName).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Password).HasMaxLength(200);
            builder.Property(x => x.Biography).HasMaxLength(700);

            builder.HasData(
            new AppUser
            {
                Id = 1,
                FirstName = "Osman",
                LastName = "Topuz",
                Email = "osmantopuz98@gmail.com",
                Password = "123456",
                Biography = "Web Dev.",
            });

        }
    }
}
