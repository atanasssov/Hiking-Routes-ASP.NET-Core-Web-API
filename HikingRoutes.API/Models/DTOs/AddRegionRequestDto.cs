using System.ComponentModel.DataAnnotations;

using static HikingRoutes.API.Common.EntityVlidationConstants.Region;

namespace HikingRoutes.API.Models.DTOs
{
    public class AddRegionRequestDto
    {
        [Required]
        [StringLength(CodeMaxLength, MinimumLength = CodeMinLength,
                      ErrorMessage = "{0} must be between {2} and {1} characters!")]
        public string Code { get; set; } = null!;


        [Required]
        [StringLength(NameMaxLength,MinimumLength = NameMinLength, 
                      ErrorMessage = "{0} must be between {2} and {1} characters!")]
        public string Name { get; set; } = null!;

        [Url]
        [MaxLength(ImageUrlMaxLength, ErrorMessage = "{0} can not be more than {1} characters!")]
        public string? RegionImageUrl { get; set; }
    }
}
