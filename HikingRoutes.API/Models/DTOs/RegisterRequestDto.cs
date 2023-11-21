using System.ComponentModel.DataAnnotations;

namespace HikingRoutes.API.Models.DTOs
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public string[] Roles { get; set; }
    }
}
