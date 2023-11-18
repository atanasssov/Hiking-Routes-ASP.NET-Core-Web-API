using Microsoft.EntityFrameworkCore;

using HikingRoutes.API.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingRoutes.API.Data.Configurations
{
    public class DifficultiesEntityConfiguration : IEntityTypeConfiguration<Difficulty>
    {
        public void Configure(EntityTypeBuilder<Difficulty> builder)
        {
            builder.HasData(this.GenerateDifficulties());
        }

        private Difficulty[] GenerateDifficulties()
        {
            ICollection<Difficulty> difficulties = new HashSet<Difficulty>();

            Difficulty difficulty;

            difficulty = new Difficulty
            {
                Name = "Easy"
            };
            difficulties.Add(difficulty);

            difficulty = new Difficulty
            {
                Name = "Medium"
            };
            difficulties.Add(difficulty);

            difficulty = new Difficulty
            {
                Name = "Hard"
            };
            difficulties.Add(difficulty);

            return difficulties.ToArray();
        }
    }
}
