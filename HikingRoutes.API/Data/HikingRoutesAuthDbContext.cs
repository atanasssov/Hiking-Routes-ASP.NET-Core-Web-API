using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HikingRoutes.API.Data
{
    public class HikingRoutesAuthDbContext : IdentityDbContext
    {
        public HikingRoutesAuthDbContext(DbContextOptions <HikingRoutesAuthDbContext> dbContextOptions) 
                                        : base(dbContextOptions)
        {

        }
    }
}
