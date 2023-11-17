using System.ComponentModel.DataAnnotations;

using static HikingRoutes.API.Common.EntityVlidationConstants.Difficulty;

namespace HikingRoutes.API.Models.Domain
{
    public class Difficulty
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
