using HikingRoutes.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingRoutes.API.Data.Configurations
{
    public class RegionsEntityConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(this.GenerateRegions());
        }

        private Region[] GenerateRegions()
        {
            ICollection<Region> regions = new HashSet<Region>();

            Region region;

            region = new Region
            {
                Code = "VAR",
                Name = "Varna",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "BUR",
                Name = "Burgas",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "PLO",
                Name = "Plovdiv",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            return regions.ToArray();
        } 
    }
}
