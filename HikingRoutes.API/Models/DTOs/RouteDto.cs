﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HikingRoutes.API.Models.DTOs
{
    public class RouteDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double LengthInKm { get; set; }

        public string? WalkImageUrl { get; set; }

        public RegionDto Region { get; set; } = null!;

        public DifficultyDto Difficulty { get; set; } = null!;

    }
}
