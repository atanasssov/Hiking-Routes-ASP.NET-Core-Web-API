using System.ComponentModel.DataAnnotations;

namespace HikingRoutes.API.Models.DTOs
{
    public class DifficultyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
