using System.ComponentModel.DataAnnotations;

using static HikingRoutes.API.Common.EntityVlidationConstants.Route;


namespace HikingRoutes.API.Models.DTOs
{
    public class UpdateRouteRequestDto
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
                      ErrorMessage = "{0} must be between {2} and {1} characters!")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength,
                      ErrorMessage = "{0} must be between {2} and {1} characters!")]
        public string Description { get; set; } = null!;

        [Required]
        [Range(LengthInKmMinValue, LengthInKmMaxValue)]
        public double LengthInKm { get; set; }

        [Url]
        [MaxLength(ImageUrlMaxLength)]
        public string? WalkImageUrl { get; set; }

        [Required]
        public Guid DifficultyId { get; set; }

        [Required]
        public Guid RegionId { get; set; }
    }
}
