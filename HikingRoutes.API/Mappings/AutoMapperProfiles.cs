using HikingRoutes.API.Models.Domain;
using HikingRoutes.API.Models.DTOs;

using AutoMapper;

// Use Aliases
using Route = HikingRoutes.API.Models.Domain.Route;


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
            CreateMap<UpdateRouteRequestDto, Route>().ReverseMap();

            //mappings for difficulty
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
           
        }
    }
}
