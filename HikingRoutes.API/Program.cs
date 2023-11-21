using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

builder.Services.AddDbContext<HikingRoutesAuthDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HikingRoutesAuthConnectionString")));

builder.Services.AddScoped<IRegionsRepository, RegionsRepository>();
builder.Services.AddScoped<IRoutesRepository, RoutesRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"] ?? ""))
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
