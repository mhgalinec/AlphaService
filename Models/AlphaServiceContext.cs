using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class AlphaServiceContext : DbContext
    {

        public AlphaServiceContext()
        {

        }

        public AlphaServiceContext(DbContextOptions<AlphaServiceContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<UserOrderRelationship> UserOrderRelationships { get; set; }
        public virtual DbSet<BikeBrand> BikeBrands { get; set; }
        public virtual DbSet<BikeModel> BikeModels { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-P6DOUNS\\SQLSERVER;Initial Catalog=PowerFit;Integrated Security=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BikeBrand>().HasData(
                new BikeBrand { BikeBrandId = 1, Name = "Aprilia"},
                new BikeBrand { BikeBrandId = 2, Name = "Ducati"},
                new BikeBrand { BikeBrandId = 3, Name = "Yamaha" },
                new BikeBrand { BikeBrandId = 4, Name = "Kawasaki" },
                new BikeBrand { BikeBrandId = 5, Name = "Suzuki" }
                );

            modelBuilder.Entity<BikeModel>().HasData(
                new BikeModel { BikeModelId = 1, Name = "RS 50", LastSupportedYear = 1994, BikeBrandId = 1},
                new BikeModel { BikeModelId = 2, Name = "Tuono", LastSupportedYear = 1995, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 3, Name = "RSV4 1100", LastSupportedYear = 1991, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 4, Name = "RSV4 125", LastSupportedYear = 1996, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 5, Name = "RS 125", LastSupportedYear = 1992, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 6, Name = "SR 50", LastSupportedYear = 1995, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 7, Name = "SR 125", LastSupportedYear = 1994, BikeBrandId = 1 },
                new BikeModel { BikeModelId = 8, Name = "Paningale V4", LastSupportedYear = 1996, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 9, Name = "Scrambler 800", LastSupportedYear = 1991, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 10, Name = "Diavel", LastSupportedYear = 1991, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 11, Name = "Monster", LastSupportedYear = 1991, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 12, Name = "Paningale V2", LastSupportedYear = 1991, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 13, Name = "Hypermotard", LastSupportedYear = 1991, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 14, Name = "Streetfighter", LastSupportedYear = 1996, BikeBrandId = 2 },
                new BikeModel { BikeModelId = 15, Name = "MT-03", LastSupportedYear = 1995, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 16, Name = "MT-07", LastSupportedYear = 1991, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 17, Name = "MT-09", LastSupportedYear = 1994, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 18, Name = "R1", LastSupportedYear = 1993, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 19, Name = "R6", LastSupportedYear = 1995, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 20, Name = "R7", LastSupportedYear = 1991, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 21, Name = "R125", LastSupportedYear = 1991, BikeBrandId = 3 },
                new BikeModel { BikeModelId = 22, Name = "Ninja H2", LastSupportedYear = 1995, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 23, Name = "Ninja 300", LastSupportedYear = 1992, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 24, Name = "Ninja 650", LastSupportedYear = 1991, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 25, Name = "Ninja ZX-10R", LastSupportedYear = 1993, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 26, Name = "Z750", LastSupportedYear = 1993, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 27, Name = "Z900", LastSupportedYear = 1995, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 28, Name = "Ninja H2", LastSupportedYear = 1994, BikeBrandId = 4 },
                new BikeModel { BikeModelId = 29, Name = "Hayabusa", LastSupportedYear = 1992, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 30, Name = "Burgman 400", LastSupportedYear = 1992, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 31, Name = "GSX 600R", LastSupportedYear = 1992, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 32, Name = "GSX 1000R", LastSupportedYear = 1994, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 33, Name = "GSX 750R", LastSupportedYear = 1996, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 34, Name = "GSX 1000S", LastSupportedYear = 1995, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 35, Name = "GSR 600", LastSupportedYear = 1995, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 36, Name = "GSR 750", LastSupportedYear = 1995, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 37, Name = "GSR 1000", LastSupportedYear = 1993, BikeBrandId = 5 },
                new BikeModel { BikeModelId = 38, Name = "GSX 750S", LastSupportedYear = 1993, BikeBrandId = 5 }
                );
            modelBuilder.Entity<Bike>().HasData(
                new Bike { BikeId = 1, Brand = "Aprilia", Model = "RS 50", LastSupportedYear = 1994, ChainPrice = 85.00, OilPrice = 23.00, AirFilterPrice = 18.00, BrakeFluidPrice = 44.00 },
                new Bike { BikeId = 2, Brand = "Aprilia", Model = "Tuono", LastSupportedYear = 1995, ChainPrice = 77.00, OilPrice = 20.00, AirFilterPrice = 24.00, BrakeFluidPrice = 42.00 },
                new Bike { BikeId = 3, Brand = "Aprilia", Model = "RSV4 1100", LastSupportedYear = 1991, ChainPrice = 80.00, OilPrice = 42.00, AirFilterPrice = 17.00, BrakeFluidPrice = 23.00 },
                new Bike { BikeId = 4, Brand = "Aprilia", Model = "RSV4 125", LastSupportedYear = 1996, ChainPrice = 58.00, OilPrice = 32.00, AirFilterPrice = 22.00, BrakeFluidPrice = 38.00 },
                new Bike { BikeId = 5, Brand = "Aprilia", Model = "RS 125", LastSupportedYear = 1992, ChainPrice = 56.00, OilPrice = 22.00, AirFilterPrice = 30.00, BrakeFluidPrice = 32.00 },
                new Bike { BikeId = 6, Brand = "Aprilia", Model = "SR 50", LastSupportedYear = 1995, ChainPrice = 83.00, OilPrice = 28.00, AirFilterPrice = 20.00, BrakeFluidPrice = 39.00 },
                new Bike { BikeId = 7, Brand = "Aprilia", Model = "SR 125", LastSupportedYear = 1994, ChainPrice = 82.00, OilPrice = 23.00, AirFilterPrice = 25.00, BrakeFluidPrice = 28.00 },
                new Bike { BikeId = 8, Brand = "Ducati", Model = "Paningale V4", LastSupportedYear = 1996, ChainPrice = 71.00, OilPrice = 31.00, AirFilterPrice = 26.00, BrakeFluidPrice = 45.00 },
                new Bike { BikeId = 9, Brand = "Ducati", Model = "Scrambler 800", LastSupportedYear = 1991, ChainPrice = 93.00, OilPrice = 44.00, AirFilterPrice = 23.00, BrakeFluidPrice = 41.00 },
                new Bike { BikeId = 10, Brand = "Ducati", Model = "Diavel", LastSupportedYear = 1991, ChainPrice = 70.00, OilPrice = 22.00, AirFilterPrice = 29.00, BrakeFluidPrice = 35.00 },
                new Bike { BikeId = 11, Brand = "Ducati", Model = "Monster", LastSupportedYear = 1991, ChainPrice = 86.00, OilPrice = 26.00, AirFilterPrice = 17.00, BrakeFluidPrice = 25.00 },
                new Bike { BikeId = 12, Brand = "Ducati", Model = "Paningale V2", LastSupportedYear = 1991, ChainPrice = 91.00, OilPrice = 32.00, AirFilterPrice = 15.00, BrakeFluidPrice = 23.00 },
                new Bike { BikeId = 13, Brand = "Ducati", Model = "Hypermotard", LastSupportedYear = 1991, ChainPrice = 68.00, OilPrice = 39.00, AirFilterPrice = 20.00, BrakeFluidPrice = 39.00 },
                new Bike { BikeId = 14, Brand = "Ducati", Model = "Streetfighter", LastSupportedYear = 1996, ChainPrice = 91.00, OilPrice = 23.00, AirFilterPrice = 28.00, BrakeFluidPrice = 38.00 },
                new Bike { BikeId = 15, Brand = "Yamaha", Model = "MT-03", LastSupportedYear = 1995, ChainPrice = 75.00, OilPrice = 36.00, AirFilterPrice = 29.00, BrakeFluidPrice = 34.00 },
                new Bike { BikeId = 16, Brand = "Yamaha", Model = "MT-07", LastSupportedYear = 1991, ChainPrice = 50.00, OilPrice = 43.00, AirFilterPrice = 27.00, BrakeFluidPrice = 43.00 },
                new Bike { BikeId = 17, Brand = "Yamaha", Model = "MT-09", LastSupportedYear = 1994, ChainPrice = 92.00, OilPrice = 26.00, AirFilterPrice = 20.00, BrakeFluidPrice = 40.00 },
                new Bike { BikeId = 18, Brand = "Yamaha", Model = "R1", LastSupportedYear = 1993, ChainPrice = 48.00, OilPrice = 38.00, AirFilterPrice = 25.00, BrakeFluidPrice = 40.00 },
                new Bike { BikeId = 19, Brand = "Yamaha", Model = "R6", LastSupportedYear = 1995, ChainPrice = 74.00, OilPrice = 29.00, AirFilterPrice = 27.00, BrakeFluidPrice = 38.00 },
                new Bike { BikeId = 20, Brand = "Yamaha", Model = "R7", LastSupportedYear = 1991, ChainPrice = 87.00, OilPrice = 45.00, AirFilterPrice = 28.00, BrakeFluidPrice = 22.00 },
                new Bike { BikeId = 21, Brand = "Yamaha", Model = "R125", LastSupportedYear = 1991, ChainPrice = 52.00, OilPrice = 44.00, AirFilterPrice = 24.00, BrakeFluidPrice = 28.00 },
                new Bike { BikeId = 22, Brand = "Kawasaki", Model = "Ninja H2", LastSupportedYear = 1995, ChainPrice = 48.00, OilPrice = 37.00, AirFilterPrice = 28.00, BrakeFluidPrice = 26.00 },
                new Bike { BikeId = 23, Brand = "Kawasaki", Model = "Ninja 300", LastSupportedYear = 1992, ChainPrice = 44.00, OilPrice = 38.00, AirFilterPrice = 23.00, BrakeFluidPrice = 26.00 },
                new Bike { BikeId = 24, Brand = "Kawasaki", Model = "Ninja 650", LastSupportedYear = 1991, ChainPrice = 69.00, OilPrice = 33.00, AirFilterPrice = 27.00, BrakeFluidPrice = 29.00 },
                new Bike { BikeId = 25, Brand = "Kawasaki", Model = "Ninja ZX-10R", LastSupportedYear = 1993, ChainPrice = 50.00, OilPrice = 34.00, AirFilterPrice = 24.00, BrakeFluidPrice = 38.00 },
                new Bike { BikeId = 26, Brand = "Kawasaki", Model = "Z750", LastSupportedYear = 1993, ChainPrice = 82.00, OilPrice = 30.00, AirFilterPrice = 19.00, BrakeFluidPrice = 27.00 },
                new Bike { BikeId = 27, Brand = "Kawasaki", Model = "Z900", LastSupportedYear = 1993, ChainPrice = 89.00, OilPrice = 37.00, AirFilterPrice = 26.00, BrakeFluidPrice = 43.00 },
                new Bike { BikeId = 28, Brand = "Kawasaki", Model = "Ninja H2", LastSupportedYear = 1995, ChainPrice = 48.00, OilPrice = 37.00, AirFilterPrice = 28.00, BrakeFluidPrice = 26.00 },
                new Bike { BikeId = 29, Brand = "Suzuki", Model = "Hayabusa", LastSupportedYear = 1994, ChainPrice = 44.00, OilPrice = 36.00, AirFilterPrice = 24.00, BrakeFluidPrice = 28.00 },
                new Bike { BikeId = 30, Brand = "Suzuki", Model = "Burgman 400", LastSupportedYear = 1992, ChainPrice = 58.00, OilPrice = 41.00, AirFilterPrice = 15.00, BrakeFluidPrice = 30.00 },
                new Bike { BikeId = 31, Brand = "Suzuki", Model = "GSX 600R", LastSupportedYear = 1992, ChainPrice = 95.00, OilPrice = 42.00, AirFilterPrice = 30.00, BrakeFluidPrice = 43.00 },
                new Bike { BikeId = 32, Brand = "Suzuki", Model = "GSX 1000R", LastSupportedYear = 1994, ChainPrice = 80.00, OilPrice = 43.00, AirFilterPrice = 24.00, BrakeFluidPrice = 24.00 },
                new Bike { BikeId = 33, Brand = "Suzuki", Model = "GSX 750R", LastSupportedYear = 1996, ChainPrice = 79.00, OilPrice = 36.00, AirFilterPrice = 22.00, BrakeFluidPrice = 25.00 },
                new Bike { BikeId = 34, Brand = "Suzuki", Model = "GSX 750S", LastSupportedYear = 1995, ChainPrice = 49.00, OilPrice = 45.00, AirFilterPrice = 15.00, BrakeFluidPrice = 20.00 },
                new Bike { BikeId = 35, Brand = "Suzuki", Model = "GSX 1000S", LastSupportedYear = 1995, ChainPrice = 100.00, OilPrice = 41.00, AirFilterPrice = 17.00, BrakeFluidPrice = 30.00 },
                new Bike { BikeId = 36, Brand = "Suzuki", Model = "GSR 600", LastSupportedYear = 1995, ChainPrice = 99.00, OilPrice = 42.00, AirFilterPrice = 17.00, BrakeFluidPrice = 43.00 },
                new Bike { BikeId = 37, Brand = "Suzuki", Model = "GSR 750", LastSupportedYear = 1993, ChainPrice = 57.00, OilPrice = 30.00, AirFilterPrice = 19.00, BrakeFluidPrice = 36.00 },
                new Bike { BikeId = 38, Brand = "Suzuki", Model = "GSR 1000", LastSupportedYear = 1993, ChainPrice = 72.00, OilPrice = 41.00, AirFilterPrice = 29.00, BrakeFluidPrice = 31.00 }


            );

        }
    }
}
