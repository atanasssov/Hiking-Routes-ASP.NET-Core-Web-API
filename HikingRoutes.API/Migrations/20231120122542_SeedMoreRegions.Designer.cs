﻿// <auto-generated />
using System;
using HikingRoutes.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HikingRoutes.API.Migrations
{
    [DbContext(typeof(HikingRoutesDbContext))]
    [Migration("20231120122542_SeedMoreRegions")]
    partial class SeedMoreRegions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HikingRoutes.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfdb74d0-8ef8-43ba-81a5-cc6d5fe36270"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("b26b0570-cf97-49a6-a74e-acf6ed6c58d0"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("777c4644-a5f7-42a5-a086-44ecd5ece1ce"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("HikingRoutes.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a85890ab-bfc7-41b4-b59c-aaab8cb61169"),
                            Code = "VAR",
                            Name = "Varna",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Varna_in_Bulgaria.svg/1024px-Varna_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("5e3e72dc-d097-478e-91e2-fd075b3b882c"),
                            Code = "BUR",
                            Name = "Burgas",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Burgas_in_Bulgaria.svg/1024px-Burgas_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("da1d1365-ee7e-43f5-95f4-90b4eebaf65c"),
                            Code = "PLO",
                            Name = "Plovdiv",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Plovdiv_in_Bulgaria.svg/250px-Plovdiv_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("c94159c3-715c-4ed1-8649-6a28130d5563"),
                            Code = "PLE",
                            Name = "Pleven",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Pleven_in_Bulgaria.svg/1024px-Pleven_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("6ed072ff-7d65-4288-851b-0d7669060ce9"),
                            Code = "SOF",
                            Name = "Sofia",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Sofia_%28province%29_in_Bulgaria.svg/1024px-Sofia_%28province%29_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("81ad011c-60f0-4969-90db-219e3e2a5728"),
                            Code = "SLI",
                            Name = "Sliven",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Sliven_in_Bulgaria.svg/1024px-Sliven_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("95962c9b-61b4-4094-97bc-259125fbc1c0"),
                            Code = "SIL",
                            Name = "Silistra",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Silistra_in_Bulgaria.svg/1024px-Silistra_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("8b5ada31-046f-477a-92d2-e82fbffa5825"),
                            Code = "YAM",
                            Name = "Yambol",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png"
                        },
                        new
                        {
                            Id = new Guid("cdd626be-d005-4a66-b647-6b985c0976dd"),
                            Code = "VID",
                            Name = "Vidin",
                            RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Yambol_in_Bulgaria.svg/1024px-Yambol_in_Bulgaria.svg.png"
                        });
                });

            modelBuilder.Entity("HikingRoutes.API.Models.Domain.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("HikingRoutes.API.Models.Domain.Route", b =>
                {
                    b.HasOne("HikingRoutes.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HikingRoutes.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
