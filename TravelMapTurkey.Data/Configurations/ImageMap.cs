using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Data.Configurations
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x=>x.FileName).HasMaxLength(256);
            builder.Property(x => x.FileType).HasMaxLength(10);

            builder.HasData(
            new Image
            {
                Id = 1,
                FileName = "post_images/image1",
                FileType = "jpg",
                CityReviewId = 1,
                CreatedDate = DateTime.Now,
            },
            new Image
            {
                Id = 2,
                FileName = "post_images/image2",
                FileType = "jpg",
                CityReviewId = 2,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
