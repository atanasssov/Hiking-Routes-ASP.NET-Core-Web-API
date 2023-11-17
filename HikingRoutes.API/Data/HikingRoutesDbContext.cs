using Microsoft.EntityFrameworkCore;

using HikingRoutes.API.Models.Domain;


namespace HikingRoutes.API.Data
{
    public class HikingRoutesDbContext : DbContext
    {
        public HikingRoutesDbContext(DbContextOptions<HikingRoutesDbContext> dbContextOptions) 
                                    : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; } = null!;

        public DbSet<Region> Regions { get; set; } = null!;

        public DbSet<HikingRoutes.API.Models.Domain.Route> Routes { get; set; }





    }
}
