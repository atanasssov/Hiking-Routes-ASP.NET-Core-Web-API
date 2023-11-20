// Use Aliases
using Microsoft.AspNetCore.Mvc;
using Route = HikingRoutes.API.Models.Domain.Route;

namespace HikingRoutes.API.Repositories
{
    public interface IRoutesRepository
    {

        /// <summary>
        /// Return all routes in the data store
        /// </summary>
        /// <param name="filterOn">Name of property to search on</param>
        /// <param name="filterQuery">Search word to filter on</param>
        /// <param name="sortBy">Name of property to sort by</param>
        /// <param name="isAscending">Way of sorting (ascending if true, descending if false)</param>
        /// <returns>List of routes from the table</returns>
        Task<List<Route>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                       string? sortBy = null, bool isAscending = true);

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


        /// <summary>
        /// Deletes a route based on the given route id
        /// </summary>
        /// <param name="id">Route id to find a route</param>
        /// <returns>Deleted route object or null</returns>
        Task<Route?> DeleteAsync(Guid id);
    }
}
