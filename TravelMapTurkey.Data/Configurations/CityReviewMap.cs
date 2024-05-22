using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Configurations
{
    public class CityReviewMap : IEntityTypeConfiguration<CityReview>
    {
        public void Configure(EntityTypeBuilder<CityReview> builder)
        {
            builder.Property(x => x.Review)
                .HasMaxLength(600);


            builder.HasData(
            new CityReview
            {
                Id = 1,
                Review = "Kalabalık bir şehir",
                CityId = 1,
            },
            new CityReview
            {
                Id = 2,
                Review = "Güzel bir şehir",
                CityId = 2,
            });

        }
    }
}
