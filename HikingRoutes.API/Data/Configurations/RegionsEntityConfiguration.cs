using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using HikingRoutes.API.Models.Domain;

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

            region = new Region
            {
                Code = "PLE",
                Name = "Pleven",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Pleven_in_Bulgaria.svg/1024px-Pleven_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "SOF",
                Name = "Sofia",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Sofia_%28province%29_in_Bulgaria.svg/1024px-Sofia_%28province%29_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "SLI",
                Name = "Sliven",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Sliven_in_Bulgaria.svg/1024px-Sliven_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "SIL",
                Name = "Silistra",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Silistra_in_Bulgaria.svg/1024px-Silistra_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "YAM",
                Name = "Yambol",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            region = new Region
            {
                Code = "VID",
                Name = "Vidin",
                RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png"
            };
            regions.Add(region);

            return regions.ToArray();
        } 
    }
}
