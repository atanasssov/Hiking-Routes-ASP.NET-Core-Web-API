using Microsoft.EntityFrameworkCore;

using HikingRoutes.API.Data;
using HikingRoutes.API.Models.Domain;

namespace HikingRoutes.API.Repositories
{
    public class RegionsRepository : IRegionsRepository
    {
        private readonly HikingRoutesDbContext _dbContext;

        public RegionsRepository(HikingRoutesDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Region>> GetAllAsync()
        {
            return await _dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await _dbContext.Regions.AddAsync(region);
            await _dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            Region? existingRegion = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);

            if(existingRegion == null)
            {
                return null;
            }

            existingRegion.Code = region.Code;
            existingRegion.Name = region.Name;
            existingRegion.RegionImageUrl = region.RegionImageUrl;

            await _dbContext.SaveChangesAsync();
            return existingRegion;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            Region? existingRegion = await _dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);

            if(existingRegion == null)
            {
                return null;
            }

            _dbContext.Regions.Remove(existingRegion);
            await _dbContext.SaveChangesAsync();

            return existingRegion;
        }
    }
}
