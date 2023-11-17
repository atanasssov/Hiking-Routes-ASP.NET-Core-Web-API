using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HikingRoutes.API.Common.EntityVlidationConstants.Route;

namespace HikingRoutes.API.Models.Domain
{
    public class Route
    {
        public Route()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public double LengthInKm { get; set; }

        [MaxLength(ImageUrlMaxLength)]
        public string? WalkImageUrl { get; set; }   

        [ForeignKey(nameof(Difficulty))]
        public Guid DifficultyId { get; set; }

        //Navigation property
        public Difficulty Difficulty { get; set; } = null!;

        [ForeignKey(nameof(Region))]
        public Guid RegionId { get; set; }

        // Navigation property
        public Region Region { get; set; } = null!;
    }
}
