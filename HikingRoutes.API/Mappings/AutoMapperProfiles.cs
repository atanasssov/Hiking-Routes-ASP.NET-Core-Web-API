﻿using HikingRoutes.API.Models.Domain;
using HikingRoutes.API.Models.DTOs;

using AutoMapper;

namespace HikingRoutes.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
        }
    }
}
