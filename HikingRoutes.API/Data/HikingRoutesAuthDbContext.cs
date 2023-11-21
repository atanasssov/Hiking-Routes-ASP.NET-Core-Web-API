using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HikingRoutes.API.Data
{
    public class HikingRoutesAuthDbContext : IdentityDbContext
    {
        public HikingRoutesAuthDbContext(DbContextOptions <HikingRoutesAuthDbContext> dbContextOptions) 
                                        : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            string? readerRoleId = "da9acf9e-4fc0-4df8-b9d1-ff7ace245c73";
            string? writerRoleId = "db1280ed-0eaa-441d-af34-15f632800e75";

            ICollection<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }   
        
    }
}
