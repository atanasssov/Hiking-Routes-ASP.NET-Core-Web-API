// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;

namespace HikingRoutes.API.Repositories
{
    public interface IRoutesRepository
    {
        /// <summary>
        /// Creates a route object and adds it to the data store
        /// </summary>
        /// <param name="route">Route object to add</param>
        /// <returns>Route object after adding it to the table</returns>
        Task<Route> CreateAsync(Route route);
    }
}
