using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HikingRoutes.API.Models.Domain
{
    public class Image
    {
        public Image()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [NotMapped]
        public IFormFile File { get; set; } = null!;

        [Required]
        public string FileName { get; set; } = null!;

        public string? FileDescription { get; set; } 

        [Required]
        public string FileExtension { get; set; } = null!;

        [Required]
        public long FileSizeInBytes { get; set; }

        [Required]
        public string FilePath { get; set; } = null!;
    }
}
