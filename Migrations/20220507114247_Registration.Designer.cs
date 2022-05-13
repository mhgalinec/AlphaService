﻿// <auto-generated />
using System;
using AlphaService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlphaService.Migrations
{
    [DbContext(typeof(AlphaServiceContext))]
    [Migration("20220507114247_Registration")]
    partial class Registration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlphaService.Models.Bike", b =>
                {
                    b.Property<int>("BikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AirFilterPrice")
                        .HasColumnType("float");

                    b.Property<double>("BrakeFluidPrice")
                        .HasColumnType("float");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ChainPrice")
                        .HasColumnType("float");

                    b.Property<int>("LastSupportedYear")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OilPrice")
                        .HasColumnType("float");

                    b.HasKey("BikeId");

                    b.ToTable("Bikes");

                    b.HasData(
                        new
                        {
                            BikeId = 1,
                            AirFilterPrice = 18.0,
                            BrakeFluidPrice = 44.0,
                            Brand = "Aprilia",
                            ChainPrice = 85.0,
                            LastSupportedYear = 1994,
                            Model = "RS 50",
                            OilPrice = 23.0
                        },
                        new
                        {
                            BikeId = 2,
                            AirFilterPrice = 24.0,
                            BrakeFluidPrice = 42.0,
                            Brand = "Aprilia",
                            ChainPrice = 77.0,
                            LastSupportedYear = 1995,
                            Model = "Tuono",
                            OilPrice = 20.0
                        },
                        new
                        {
                            BikeId = 3,
                            AirFilterPrice = 17.0,
                            BrakeFluidPrice = 23.0,
                            Brand = "Aprilia",
                            ChainPrice = 80.0,
                            LastSupportedYear = 1991,
                            Model = "RSV4 1100",
                            OilPrice = 42.0
                        },
                        new
                        {
                            BikeId = 4,
                            AirFilterPrice = 22.0,
                            BrakeFluidPrice = 38.0,
                            Brand = "Aprilia",
                            ChainPrice = 58.0,
                            LastSupportedYear = 1996,
                            Model = "RSV4 125",
                            OilPrice = 32.0
                        },
                        new
                        {
                            BikeId = 5,
                            AirFilterPrice = 30.0,
                            BrakeFluidPrice = 32.0,
                            Brand = "Aprilia",
                            ChainPrice = 56.0,
                            LastSupportedYear = 1992,
                            Model = "RS 125",
                            OilPrice = 22.0
                        },
                        new
                        {
                            BikeId = 6,
                            AirFilterPrice = 20.0,
                            BrakeFluidPrice = 39.0,
                            Brand = "Aprilia",
                            ChainPrice = 83.0,
                            LastSupportedYear = 1995,
                            Model = "SR 50",
                            OilPrice = 28.0
                        },
                        new
                        {
                            BikeId = 7,
                            AirFilterPrice = 25.0,
                            BrakeFluidPrice = 28.0,
                            Brand = "Aprilia",
                            ChainPrice = 82.0,
                            LastSupportedYear = 1994,
                            Model = "SR 125",
                            OilPrice = 23.0
                        },
                        new
                        {
                            BikeId = 8,
                            AirFilterPrice = 26.0,
                            BrakeFluidPrice = 45.0,
                            Brand = "Ducati",
                            ChainPrice = 71.0,
                            LastSupportedYear = 1996,
                            Model = "Paningale V4",
                            OilPrice = 31.0
                        },
                        new
                        {
                            BikeId = 9,
                            AirFilterPrice = 23.0,
                            BrakeFluidPrice = 41.0,
                            Brand = "Ducati",
                            ChainPrice = 93.0,
                            LastSupportedYear = 1991,
                            Model = "Scrambler 800",
                            OilPrice = 44.0
                        },
                        new
                        {
                            BikeId = 10,
                            AirFilterPrice = 29.0,
                            BrakeFluidPrice = 35.0,
                            Brand = "Ducati",
                            ChainPrice = 70.0,
                            LastSupportedYear = 1991,
                            Model = "Diavel",
                            OilPrice = 22.0
                        },
                        new
                        {
                            BikeId = 11,
                            AirFilterPrice = 17.0,
                            BrakeFluidPrice = 25.0,
                            Brand = "Ducati",
                            ChainPrice = 86.0,
                            LastSupportedYear = 1991,
                            Model = "Monster",
                            OilPrice = 26.0
                        },
                        new
                        {
                            BikeId = 12,
                            AirFilterPrice = 15.0,
                            BrakeFluidPrice = 23.0,
                            Brand = "Ducati",
                            ChainPrice = 91.0,
                            LastSupportedYear = 1991,
                            Model = "Paningale V2",
                            OilPrice = 32.0
                        },
                        new
                        {
                            BikeId = 13,
                            AirFilterPrice = 20.0,
                            BrakeFluidPrice = 39.0,
                            Brand = "Ducati",
                            ChainPrice = 68.0,
                            LastSupportedYear = 1991,
                            Model = "Hypermotard",
                            OilPrice = 39.0
                        },
                        new
                        {
                            BikeId = 14,
                            AirFilterPrice = 28.0,
                            BrakeFluidPrice = 38.0,
                            Brand = "Ducati",
                            ChainPrice = 91.0,
                            LastSupportedYear = 1996,
                            Model = "Streetfighter",
                            OilPrice = 23.0
                        },
                        new
                        {
                            BikeId = 15,
                            AirFilterPrice = 29.0,
                            BrakeFluidPrice = 34.0,
                            Brand = "Yamaha",
                            ChainPrice = 75.0,
                            LastSupportedYear = 1995,
                            Model = "MT-03",
                            OilPrice = 36.0
                        },
                        new
                        {
                            BikeId = 16,
                            AirFilterPrice = 27.0,
                            BrakeFluidPrice = 43.0,
                            Brand = "Yamaha",
                            ChainPrice = 50.0,
                            LastSupportedYear = 1991,
                            Model = "MT-07",
                            OilPrice = 43.0
                        },
                        new
                        {
                            BikeId = 17,
                            AirFilterPrice = 20.0,
                            BrakeFluidPrice = 40.0,
                            Brand = "Yamaha",
                            ChainPrice = 92.0,
                            LastSupportedYear = 1994,
                            Model = "MT-09",
                            OilPrice = 26.0
                        },
                        new
                        {
                            BikeId = 18,
                            AirFilterPrice = 25.0,
                            BrakeFluidPrice = 40.0,
                            Brand = "Yamaha",
                            ChainPrice = 48.0,
                            LastSupportedYear = 1993,
                            Model = "R1",
                            OilPrice = 38.0
                        },
                        new
                        {
                            BikeId = 19,
                            AirFilterPrice = 27.0,
                            BrakeFluidPrice = 38.0,
                            Brand = "Yamaha",
                            ChainPrice = 74.0,
                            LastSupportedYear = 1995,
                            Model = "R6",
                            OilPrice = 29.0
                        },
                        new
                        {
                            BikeId = 20,
                            AirFilterPrice = 28.0,
                            BrakeFluidPrice = 22.0,
                            Brand = "Yamaha",
                            ChainPrice = 87.0,
                            LastSupportedYear = 1991,
                            Model = "R7",
                            OilPrice = 45.0
                        },
                        new
                        {
                            BikeId = 21,
                            AirFilterPrice = 24.0,
                            BrakeFluidPrice = 28.0,
                            Brand = "Yamaha",
                            ChainPrice = 52.0,
                            LastSupportedYear = 1991,
                            Model = "R125",
                            OilPrice = 44.0
                        },
                        new
                        {
                            BikeId = 22,
                            AirFilterPrice = 28.0,
                            BrakeFluidPrice = 26.0,
                            Brand = "Kawasaki",
                            ChainPrice = 48.0,
                            LastSupportedYear = 1995,
                            Model = "Ninja H2",
                            OilPrice = 37.0
                        },
                        new
                        {
                            BikeId = 23,
                            AirFilterPrice = 23.0,
                            BrakeFluidPrice = 26.0,
                            Brand = "Kawasaki",
                            ChainPrice = 44.0,
                            LastSupportedYear = 1992,
                            Model = "Ninja 300",
                            OilPrice = 38.0
                        },
                        new
                        {
                            BikeId = 24,
                            AirFilterPrice = 27.0,
                            BrakeFluidPrice = 29.0,
                            Brand = "Kawasaki",
                            ChainPrice = 69.0,
                            LastSupportedYear = 1991,
                            Model = "Ninja 650",
                            OilPrice = 33.0
                        },
                        new
                        {
                            BikeId = 25,
                            AirFilterPrice = 24.0,
                            BrakeFluidPrice = 38.0,
                            Brand = "Kawasaki",
                            ChainPrice = 50.0,
                            LastSupportedYear = 1993,
                            Model = "Ninja ZX-10R",
                            OilPrice = 34.0
                        },
                        new
                        {
                            BikeId = 26,
                            AirFilterPrice = 19.0,
                            BrakeFluidPrice = 27.0,
                            Brand = "Kawasaki",
                            ChainPrice = 82.0,
                            LastSupportedYear = 1993,
                            Model = "Z750",
                            OilPrice = 30.0
                        },
                        new
                        {
                            BikeId = 27,
                            AirFilterPrice = 26.0,
                            BrakeFluidPrice = 43.0,
                            Brand = "Kawasaki",
                            ChainPrice = 89.0,
                            LastSupportedYear = 1993,
                            Model = "Z900",
                            OilPrice = 37.0
                        },
                        new
                        {
                            BikeId = 28,
                            AirFilterPrice = 28.0,
                            BrakeFluidPrice = 26.0,
                            Brand = "Kawasaki",
                            ChainPrice = 48.0,
                            LastSupportedYear = 1995,
                            Model = "Ninja H2",
                            OilPrice = 37.0
                        },
                        new
                        {
                            BikeId = 29,
                            AirFilterPrice = 24.0,
                            BrakeFluidPrice = 28.0,
                            Brand = "Suzuki",
                            ChainPrice = 44.0,
                            LastSupportedYear = 1994,
                            Model = "Hayabusa",
                            OilPrice = 36.0
                        },
                        new
                        {
                            BikeId = 30,
                            AirFilterPrice = 15.0,
                            BrakeFluidPrice = 30.0,
                            Brand = "Suzuki",
                            ChainPrice = 58.0,
                            LastSupportedYear = 1992,
                            Model = "Burgman 400",
                            OilPrice = 41.0
                        },
                        new
                        {
                            BikeId = 31,
                            AirFilterPrice = 30.0,
                            BrakeFluidPrice = 43.0,
                            Brand = "Suzuki",
                            ChainPrice = 95.0,
                            LastSupportedYear = 1992,
                            Model = "GSX 600R",
                            OilPrice = 42.0
                        },
                        new
                        {
                            BikeId = 32,
                            AirFilterPrice = 24.0,
                            BrakeFluidPrice = 24.0,
                            Brand = "Suzuki",
                            ChainPrice = 80.0,
                            LastSupportedYear = 1994,
                            Model = "GSX 1000R",
                            OilPrice = 43.0
                        },
                        new
                        {
                            BikeId = 33,
                            AirFilterPrice = 22.0,
                            BrakeFluidPrice = 25.0,
                            Brand = "Suzuki",
                            ChainPrice = 79.0,
                            LastSupportedYear = 1996,
                            Model = "GSX 750R",
                            OilPrice = 36.0
                        },
                        new
                        {
                            BikeId = 34,
                            AirFilterPrice = 15.0,
                            BrakeFluidPrice = 20.0,
                            Brand = "Suzuki",
                            ChainPrice = 49.0,
                            LastSupportedYear = 1995,
                            Model = "GSX 750S",
                            OilPrice = 45.0
                        },
                        new
                        {
                            BikeId = 35,
                            AirFilterPrice = 17.0,
                            BrakeFluidPrice = 30.0,
                            Brand = "Suzuki",
                            ChainPrice = 100.0,
                            LastSupportedYear = 1995,
                            Model = "GSX 1000S",
                            OilPrice = 41.0
                        },
                        new
                        {
                            BikeId = 36,
                            AirFilterPrice = 17.0,
                            BrakeFluidPrice = 43.0,
                            Brand = "Suzuki",
                            ChainPrice = 99.0,
                            LastSupportedYear = 1995,
                            Model = "GSR 600",
                            OilPrice = 42.0
                        },
                        new
                        {
                            BikeId = 37,
                            AirFilterPrice = 19.0,
                            BrakeFluidPrice = 36.0,
                            Brand = "Suzuki",
                            ChainPrice = 57.0,
                            LastSupportedYear = 1993,
                            Model = "GSR 750",
                            OilPrice = 30.0
                        },
                        new
                        {
                            BikeId = 38,
                            AirFilterPrice = 29.0,
                            BrakeFluidPrice = 31.0,
                            Brand = "Suzuki",
                            ChainPrice = 72.0,
                            LastSupportedYear = 1993,
                            Model = "GSR 1000",
                            OilPrice = 41.0
                        });
                });

            modelBuilder.Entity("AlphaService.Models.BikeBrand", b =>
                {
                    b.Property<int>("BikeBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeBrandId");

                    b.ToTable("BikeBrands");

                    b.HasData(
                        new
                        {
                            BikeBrandId = 1,
                            Name = "Aprilia"
                        },
                        new
                        {
                            BikeBrandId = 2,
                            Name = "Ducati"
                        },
                        new
                        {
                            BikeBrandId = 3,
                            Name = "Yamaha"
                        },
                        new
                        {
                            BikeBrandId = 4,
                            Name = "Kawasaki"
                        },
                        new
                        {
                            BikeBrandId = 5,
                            Name = "Suzuki"
                        });
                });

            modelBuilder.Entity("AlphaService.Models.BikeModel", b =>
                {
                    b.Property<int>("BikeModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BikeBrandId")
                        .HasColumnType("int");

                    b.Property<int>("LastSupportedYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BikeModelId");

                    b.HasIndex("BikeBrandId");

                    b.ToTable("BikeModels");

                    b.HasData(
                        new
                        {
                            BikeModelId = 1,
                            BikeBrandId = 1,
                            LastSupportedYear = 1994,
                            Name = "RS 50"
                        },
                        new
                        {
                            BikeModelId = 2,
                            BikeBrandId = 1,
                            LastSupportedYear = 1995,
                            Name = "Tuono"
                        },
                        new
                        {
                            BikeModelId = 3,
                            BikeBrandId = 1,
                            LastSupportedYear = 1991,
                            Name = "RSV4 1100"
                        },
                        new
                        {
                            BikeModelId = 4,
                            BikeBrandId = 1,
                            LastSupportedYear = 1996,
                            Name = "RSV4 125"
                        },
                        new
                        {
                            BikeModelId = 5,
                            BikeBrandId = 1,
                            LastSupportedYear = 1992,
                            Name = "RS 125"
                        },
                        new
                        {
                            BikeModelId = 6,
                            BikeBrandId = 1,
                            LastSupportedYear = 1995,
                            Name = "SR 50"
                        },
                        new
                        {
                            BikeModelId = 7,
                            BikeBrandId = 1,
                            LastSupportedYear = 1994,
                            Name = "SR 125"
                        },
                        new
                        {
                            BikeModelId = 8,
                            BikeBrandId = 2,
                            LastSupportedYear = 1996,
                            Name = "Paningale V4"
                        },
                        new
                        {
                            BikeModelId = 9,
                            BikeBrandId = 2,
                            LastSupportedYear = 1991,
                            Name = "Scrambler 800"
                        },
                        new
                        {
                            BikeModelId = 10,
                            BikeBrandId = 2,
                            LastSupportedYear = 1991,
                            Name = "Diavel"
                        },
                        new
                        {
                            BikeModelId = 11,
                            BikeBrandId = 2,
                            LastSupportedYear = 1991,
                            Name = "Monster"
                        },
                        new
                        {
                            BikeModelId = 12,
                            BikeBrandId = 2,
                            LastSupportedYear = 1991,
                            Name = "Paningale V2"
                        },
                        new
                        {
                            BikeModelId = 13,
                            BikeBrandId = 2,
                            LastSupportedYear = 1991,
                            Name = "Hypermotard"
                        },
                        new
                        {
                            BikeModelId = 14,
                            BikeBrandId = 2,
                            LastSupportedYear = 1996,
                            Name = "Streetfighter"
                        },
                        new
                        {
                            BikeModelId = 15,
                            BikeBrandId = 3,
                            LastSupportedYear = 1995,
                            Name = "MT-03"
                        },
                        new
                        {
                            BikeModelId = 16,
                            BikeBrandId = 3,
                            LastSupportedYear = 1991,
                            Name = "MT-07"
                        },
                        new
                        {
                            BikeModelId = 17,
                            BikeBrandId = 3,
                            LastSupportedYear = 1994,
                            Name = "MT-09"
                        },
                        new
                        {
                            BikeModelId = 18,
                            BikeBrandId = 3,
                            LastSupportedYear = 1993,
                            Name = "R1"
                        },
                        new
                        {
                            BikeModelId = 19,
                            BikeBrandId = 3,
                            LastSupportedYear = 1995,
                            Name = "R6"
                        },
                        new
                        {
                            BikeModelId = 20,
                            BikeBrandId = 3,
                            LastSupportedYear = 1991,
                            Name = "R7"
                        },
                        new
                        {
                            BikeModelId = 21,
                            BikeBrandId = 3,
                            LastSupportedYear = 1991,
                            Name = "R125"
                        },
                        new
                        {
                            BikeModelId = 22,
                            BikeBrandId = 4,
                            LastSupportedYear = 1995,
                            Name = "Ninja H2"
                        },
                        new
                        {
                            BikeModelId = 23,
                            BikeBrandId = 4,
                            LastSupportedYear = 1992,
                            Name = "Ninja 300"
                        },
                        new
                        {
                            BikeModelId = 24,
                            BikeBrandId = 4,
                            LastSupportedYear = 1991,
                            Name = "Ninja 650"
                        },
                        new
                        {
                            BikeModelId = 25,
                            BikeBrandId = 4,
                            LastSupportedYear = 1993,
                            Name = "Ninja ZX-10R"
                        },
                        new
                        {
                            BikeModelId = 26,
                            BikeBrandId = 4,
                            LastSupportedYear = 1993,
                            Name = "Z750"
                        },
                        new
                        {
                            BikeModelId = 27,
                            BikeBrandId = 4,
                            LastSupportedYear = 1995,
                            Name = "Z900"
                        },
                        new
                        {
                            BikeModelId = 28,
                            BikeBrandId = 4,
                            LastSupportedYear = 1994,
                            Name = "Ninja H2"
                        },
                        new
                        {
                            BikeModelId = 29,
                            BikeBrandId = 5,
                            LastSupportedYear = 1992,
                            Name = "Hayabusa"
                        },
                        new
                        {
                            BikeModelId = 30,
                            BikeBrandId = 5,
                            LastSupportedYear = 1992,
                            Name = "Burgman 400"
                        },
                        new
                        {
                            BikeModelId = 31,
                            BikeBrandId = 5,
                            LastSupportedYear = 1992,
                            Name = "GSX 600R"
                        },
                        new
                        {
                            BikeModelId = 32,
                            BikeBrandId = 5,
                            LastSupportedYear = 1994,
                            Name = "GSX 1000R"
                        },
                        new
                        {
                            BikeModelId = 33,
                            BikeBrandId = 5,
                            LastSupportedYear = 1996,
                            Name = "GSX 750R"
                        },
                        new
                        {
                            BikeModelId = 34,
                            BikeBrandId = 5,
                            LastSupportedYear = 1995,
                            Name = "GSX 1000S"
                        },
                        new
                        {
                            BikeModelId = 35,
                            BikeBrandId = 5,
                            LastSupportedYear = 1995,
                            Name = "GSR 600"
                        },
                        new
                        {
                            BikeModelId = 36,
                            BikeBrandId = 5,
                            LastSupportedYear = 1995,
                            Name = "GSR 750"
                        },
                        new
                        {
                            BikeModelId = 37,
                            BikeBrandId = 5,
                            LastSupportedYear = 1993,
                            Name = "GSR 1000"
                        },
                        new
                        {
                            BikeModelId = 38,
                            BikeBrandId = 5,
                            LastSupportedYear = 1993,
                            Name = "GSX 750S"
                        });
                });

            modelBuilder.Entity("AlphaService.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AlphaService.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AlphaService.Models.UserOrderRelationship", b =>
                {
                    b.Property<int>("UserOrderRelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserOrderRelationshipId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrderRelationships");
                });

            modelBuilder.Entity("AlphaService.Models.BikeModel", b =>
                {
                    b.HasOne("AlphaService.Models.BikeBrand", "BikeBrand")
                        .WithMany("BikeModels")
                        .HasForeignKey("BikeBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BikeBrand");
                });

            modelBuilder.Entity("AlphaService.Models.UserOrderRelationship", b =>
                {
                    b.HasOne("AlphaService.Models.Order", "Order")
                        .WithMany("UserOrderRelationship")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlphaService.Models.User", "User")
                        .WithMany("UserOrderRelationship")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlphaService.Models.BikeBrand", b =>
                {
                    b.Navigation("BikeModels");
                });

            modelBuilder.Entity("AlphaService.Models.Order", b =>
                {
                    b.Navigation("UserOrderRelationship");
                });

            modelBuilder.Entity("AlphaService.Models.User", b =>
                {
                    b.Navigation("UserOrderRelationship");
                });
#pragma warning restore 612, 618
        }
    }
}
