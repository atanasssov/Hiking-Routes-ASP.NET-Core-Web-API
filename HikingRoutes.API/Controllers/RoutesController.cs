using Microsoft.AspNetCore.Mvc;

using HikingRoutes.API.Models.DTOs;

using AutoMapper;

// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;
using HikingRoutes.API.Repositories;
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

        // Post to create a new route
        // Post: https://localhost:portnumber/api/routes
        [HttpPost]

        public async Task<IActionResult> Create([FromBody] AddRouteRequestDto addRouteRequestDto)
        {
            Route routeDomain = _mapper.Map<Route>(addRouteRequestDto);

            routeDomain = await _routesRepository.CreateAsync(routeDomain);

            return Ok(_mapper.Map<RouteDto>(routeDomain));
        }
      
    }
}
