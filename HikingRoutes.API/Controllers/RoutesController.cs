using Microsoft.AspNetCore.Mvc;

using HikingRoutes.API.Models.DTOs;
using HikingRoutes.API.Repositories;
using HikingRoutes.API.CumstomActionFilters;

using AutoMapper;

// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;
//using Route2 = Microsoft.AspNetCore.Routing.Route;


namespace HikingRoutes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRoutesRepository _routesRepository;

        public RoutesController(IMapper mapper,
                                IRoutesRepository routesRepository)
        {
            _mapper = mapper;
            _routesRepository = routesRepository;
        }

        // Get all routes
        // GET: https://localhost:portnumber/api/routes?filterOn=Name&filterQuery=Mountain&sortBy=Name&isAscending=true&pageNumber=1&pageSize=5
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, 
                                                [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
                                                [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
        {

            List<Route> routeDomain = await _routesRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize);

            List<RouteDto> routeDto = _mapper.Map<List<RouteDto>>(routeDomain);

            return Ok(routeDto);
        }


        //Get single route by Id
        // GET: https://localhost:portnumber/api/routes/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            Route? routeDomain = await _routesRepository.GetByIdAsync(id);

            if (routeDomain == null)
            {
                return NotFound();
            }

            RouteDto routeDto = _mapper.Map<RouteDto>(routeDomain);

            return Ok(routeDto);

        }


        // Post to create a new route
        // Post: https://localhost:portnumber/api/routes
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddRouteRequestDto addRouteRequestDto)
        {
            Route routeDomain = _mapper.Map<Route>(addRouteRequestDto);

            routeDomain = await _routesRepository.CreateAsync(routeDomain);

            return Ok(_mapper.Map<RouteDto>(routeDomain));
        }


        // Update route by id
        // PUT: https://localhost:portnumber/api/routes/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRouteRequestDto updateRouteRequestDto)
        {
            Route? routeDomain = _mapper.Map<Route>(updateRouteRequestDto);

            routeDomain = await _routesRepository.UpdateAsync(id, routeDomain);

            if(routeDomain == null)
            {
                return NotFound();
            }

            RouteDto routeDto = _mapper.Map<RouteDto>(routeDomain);

            return Ok(routeDto);
        }

        // Delete route by id
        // DELETE: https://localhost:portnumber/api/routes/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            Route? routeDomain = await _routesRepository.DeleteAsync(id);

            if(routeDomain == null)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
