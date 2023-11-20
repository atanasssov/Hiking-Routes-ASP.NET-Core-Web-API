using HikingRoutes.API.Models.Domain;

namespace HikingRoutes.API.Repositories
{
    public interface IRegionsRepository
    {
        /// <summary>
        /// Return all regions in the data store
        /// </summary>
        /// <returns>List of regions from the table</returns>
        Task<List<Region>> GetAllAsync();


        /// <summary>
        /// Returns a region object based on the given region id
        /// </summary>
        /// <param name="id">Region id to search</param>
        /// <returns>Matching region or null</returns>
        Task<Region?> GetByIdAsync(Guid id);


        /// <summary>
        /// Creates a region object and adds it to the data store
        /// </summary>
        /// <param name="region">Region object to add</param>
        /// <returns>Region object after adding it to the table</returns>
        Task<Region> CreateAsync(Region region);


        /// <summary>
        /// Updates a region object based on the given region id
        /// </summary>
        /// <param name="id">Region id to seach in the database if region exists</param>
        /// <param name="region">Region object with the the properties</param>
        /// <returns>The updated region object or null</returns>
        Task<Region?> UpdateAsync(Guid id, Region region);

        /// <summary>
        /// Deletes a region based on the given region id
        /// </summary>
        /// <param name="id">Region id to find a region</param>
        /// <returns>Deleted region object or null</returns>
        Task<Region?> DeleteAsync(Guid id);
    }
}
