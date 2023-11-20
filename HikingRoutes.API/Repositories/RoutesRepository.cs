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

        public async Task<List<Route>> GetAllAsync(string? filterOn = null, string? filterQuery = null)
        {
            IQueryable<Route> routes = _dbContext.Routes
                .Include("Difficulty")                      //also . Include(x => x.Difficulty)
                .Include("Region")
                .AsQueryable();

            
            // Filtering

            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                //validating (name,NAME,nAmE, namE, etc)

                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))       
                {
                    // case-insensitive matching
                    // Contains method used within LINQ queries against Entity Framework for string comparison is indeed case-insensitive

                    routes = routes.Where(x => x.Name.Contains(filterQuery));

                }
            }

            return await routes.ToListAsync();

        }

        public async Task<Route?> GetByIdAsync(Guid id)
        {
            return await _dbContext
                .Routes
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Route> CreateAsync(Route route)
        {
            await _dbContext.Routes.AddAsync(route);
            await _dbContext.SaveChangesAsync();
            return route;
        }

        public async Task<Route?> UpdateAsync(Guid id, Route route)
        {
            Route? existingRoute = await _dbContext.Routes.FirstOrDefaultAsync(x => x.Id == id);

            if(existingRoute == null)
            {
                return null;
            }

            existingRoute.Name = route.Name;
            existingRoute.Description = route.Description;
            existingRoute.LengthInKm = route.LengthInKm;
            existingRoute.WalkImageUrl = route.WalkImageUrl;
            existingRoute.WalkImageUrl = route.WalkImageUrl;
            existingRoute.DifficultyId = route.DifficultyId;
            existingRoute.RegionId = route.RegionId;

            await _dbContext.SaveChangesAsync();
            return existingRoute;

        }

        public async  Task<Route?> DeleteAsync(Guid id)
        {
            Route? existingRoute = await _dbContext.Routes.FirstOrDefaultAsync(x => x.Id == id);

            if(existingRoute == null)
            {
                return null;
            }

            _dbContext.Routes.Remove(existingRoute);
            await _dbContext.SaveChangesAsync();

            return existingRoute;
        }
    }
}
