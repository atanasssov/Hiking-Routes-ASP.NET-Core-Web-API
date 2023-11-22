using HikingRoutes.API.Models.Domain;

namespace HikingRoutes.API.Repositories
{
    public interface IImagesRepository
    {
        /// <summary>
        /// Uploads an image
        /// </summary>
        /// <param name="image">Image to upload</param>
        /// <returns>The uploade image</returns>
        Task<Image> Upload(Image image);
    }
}
