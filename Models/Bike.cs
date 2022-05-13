using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class Bike
    {
        public int BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int LastSupportedYear { get; set; }
        public double ChainPrice { get; set; }
        public double OilPrice { get; set; }
        public double AirFilterPrice { get; set; }
        public double BrakeFluidPrice { get; set; }
    }
}
