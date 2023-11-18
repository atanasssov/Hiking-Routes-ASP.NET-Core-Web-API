using Microsoft.EntityFrameworkCore;

using HikingRoutes.API.Data;

// Use Aliases
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

        public async Task<List<Route>> GetAllAsync()
        {
            return await _dbContext.Routes
                .Include("Difficulty")                   //also . Include(x => x.Difficulty)
                .Include("Region")
                .ToListAsync();
        }

        public async Task<Route> CreateAsync(Route route)
        {
            await _dbContext.Routes.AddAsync(route);
            await _dbContext.SaveChangesAsync();
            return route;
        }

       
    }
}
