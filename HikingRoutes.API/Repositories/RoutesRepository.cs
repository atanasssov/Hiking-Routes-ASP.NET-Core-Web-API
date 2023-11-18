// Use Aliases
using HikingRoutes.API.Data;
using Route = HikingRoutes.API.Models.Domain.Route;

namespace HikingRoutes.API.Repositories
{
    public class RoutesRepository : IRoutesRepository
    {
        private readonly HikingRoutesDbContext _dbContext;

        public RoutesRepository(HikingRoutesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Models.Domain.Route> CreateAsync(Route route)
        {
            await _dbContext.Routes.AddAsync(route);
            await _dbContext.SaveChangesAsync();
            return route;
        }
    }
}
