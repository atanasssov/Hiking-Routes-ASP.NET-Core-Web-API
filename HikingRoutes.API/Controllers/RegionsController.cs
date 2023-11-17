using Microsoft.AspNetCore.Mvc;

using HikingRoutes.API.Data;
using HikingRoutes.API.Models.Domain;

namespace HikingRoutes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly HikingRoutesDbContext _dbContext;

        public RegionsController(HikingRoutesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all regions
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = _dbContext.Regions.ToList();
            return Ok(regions);
        }


        //Get single region by Id
        // GET: https://localhost:portnumber/api/regions/{Id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var region = _dbContext.Regions.FirstOrDefault(x => x.Id ==id);

            if(region != null)
            {
                return NotFound();
            }

            return Ok(region);
        }



    }
}
