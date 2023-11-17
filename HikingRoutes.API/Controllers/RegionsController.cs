using Microsoft.AspNetCore.Mvc;

using HikingRoutes.API.Data;
using HikingRoutes.API.Models.Domain;
using HikingRoutes.API.Models.DTOs;

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
            List<Region> regionsDomain = _dbContext.Regions.ToList();

            List<RegionDto> regionsDto = new List<RegionDto>();

            foreach(var regionDomain in regionsDomain)
            {

                regionsDto.Add(new RegionDto
                {
                    Id = regionDomain.Id,
                    Code = regionDomain.Code,
                    Name = regionDomain.Name,
                    RegionImageUrl = regionDomain.RegionImageUrl
                });
            }

            return Ok(regionsDto);
        }


        //Get single region by Id
        // GET: https://localhost:portnumber/api/regions/{Id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            Region? regionDomain = _dbContext.Regions.FirstOrDefault(x => x.Id ==id);

            if(regionDomain == null)
            {
                return NotFound();
            }

            RegionDto regionDto = new RegionDto()
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl
            };

            return Ok(regionDto);
        }



    }
}
