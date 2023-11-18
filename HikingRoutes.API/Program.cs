using Microsoft.EntityFrameworkCore;

using HikingRoutes.API.Data;
using HikingRoutes.API.Repositories;
using HikingRoutes.API.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HikingRoutesDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HikingRoutesConnectionString")));

builder.Services.AddScoped<IRegionsRepository, RegionsRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
