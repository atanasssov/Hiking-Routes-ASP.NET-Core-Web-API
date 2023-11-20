// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;

namespace HikingRoutes.API.Repositories
{
    public interface IRoutesRepository
    {
        /// <summary>
        /// Return all routes in the data store
        /// </summary>
        /// <returns>List of routes from the table</returns>
        Task<List<Route>> GetAllAsync();

        /// <summary>
        /// Returns a route object based on the given route id
        /// </summary>
        /// <param name="id">Route id to search</param>
        /// <returns>Matching route or null</returns>
        Task<Route?> GetByIdAsync(Guid id);

        /// <summary>
        /// Creates a route object and adds it to the data store
        /// </summary>
        /// <param name="route">Route object to add</param>
        /// <returns>Route object after adding it to the table</returns>
        Task<Route> CreateAsync(Route route);


        /// <summary>
        /// Updates a route object based on the given route id
        /// </summary>
        /// <param name="id">Route id to seach in the database if route exists</param>
        /// <param name="route">Route object with the the properties</param>
        /// <returns>The updated route object or null</returns>
        Task<Route?> UpdateAsync(Guid id, Route route);
    }
}
