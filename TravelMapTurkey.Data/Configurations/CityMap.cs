using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Configurations
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.CityName)
                .HasMaxLength(30);
            builder.Property(x => x.Type)
                .HasMaxLength(30);

            builder.HasData(
            new City
            {
                Id = 1,
                CityName = "Ankara",
                UserId = 1,
                Type = "Visit",
            },
            new City
            {
                Id = 2,
                CityName = "Antalya",
                UserId = 1,
                Type = "Visit",
            });

        }
    }
}
