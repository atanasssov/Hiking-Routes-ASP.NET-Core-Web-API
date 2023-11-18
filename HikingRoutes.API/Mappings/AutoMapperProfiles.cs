using HikingRoutes.API.Models.Domain;
using HikingRoutes.API.Models.DTOs;

// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;

using AutoMapper;

namespace HikingRoutes.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // mappings for region
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

            // mappings for route
            CreateMap<AddRouteRequestDto, Route>().ReverseMap();
            CreateMap<Route, RouteDto>().ReverseMap();
        }
    }
}
