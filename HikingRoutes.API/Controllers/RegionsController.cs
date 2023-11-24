using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using HikingRoutes.API.Models.Domain;
using HikingRoutes.API.Models.DTOs;
using HikingRoutes.API.Repositories;
using HikingRoutes.API.CumstomActionFilters;

using AutoMapper;
using System.Text.Json;

namespace HikingRoutes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
 
        private readonly IRegionsRepository _regionRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<RegionsController> _logger;

        public RegionsController(IRegionsRepository regionRepository,
                                 IMapper mapper,
                                 ILogger<RegionsController> logger)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
            _logger = logger;
        }

        // Get all regions
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        //[Authorize(Roles = "Reader, Writer")]
        public async Task<IActionResult> GetAll()
        {
            List<Region> regionsDomain = await _regionRepository.GetAllAsync();

            List<RegionDto> regionsDto = _mapper.Map<List<RegionDto>>(regionsDomain);

            return Ok(regionsDto);

        }


        //Get single region by Id
        // GET: https://localhost:portnumber/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            Region? regionDomain = await _regionRepository.GetByIdAsync(id);

            if(regionDomain == null)
            {
                return NotFound();
            }

            RegionDto regionDto = _mapper.Map<RegionDto>(regionDomain);
           
            return Ok(regionDto);
        }

        // Post to create a new region
        // Post: https://localhost:portnumber/api/regions
        [HttpPost]
        [ValidateModel]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            Region regionDomain = _mapper.Map<Region>(addRegionRequestDto);

            regionDomain = await _regionRepository.CreateAsync(regionDomain);

            RegionDto regionDto = _mapper.Map<RegionDto>(regionDomain);

            return CreatedAtAction(nameof(GetById), new { id = regionDto.Id }, regionDto);
        }


        // Update region by id
        // PUT: https://localhost:portnumber/api/regions/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {

            Region? regionDomain = _mapper.Map<Region>(updateRegionRequestDto);

            regionDomain = await _regionRepository.UpdateAsync(id, regionDomain);

            if(regionDomain == null)
            {
                return NotFound();
            }

            RegionDto regionDto = _mapper.Map<RegionDto>(regionDomain);

            return Ok(regionDto);
        }


        // Delete region by id
        // DELETE: https://localhost:portnumber/api/regions/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            Region? regionDomain = await _regionRepository.DeleteAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            // If we want to return the deleted object
            //RegionDto regionDto = _mapper.Map<RegionDto>(regionDomain);
            //return Ok(regionDto);

            return NoContent();
        }
    }
}
