using System.ComponentModel.DataAnnotations;

using static HikingRoutes.API.Common.EntityVlidationConstants.Region;

namespace HikingRoutes.API.Models.Domain
{
    public class Region
    {
        public Region()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(CodeMaxLength)]
        public string Code { get; set; } = null!;

        
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public string? RegionImageUrl { get; set; }

    }
}
