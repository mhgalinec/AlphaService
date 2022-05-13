using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models.ViewModels
{
    public class AddOrderViewModel
    {

        public IEnumerable<BikeModel> BikeModels { get; set; }
        public IEnumerable<BikeBrand> BikeBrands { get; set; }
        public int Mileage { get; set; }
        public int LastSupportedYear { get; set; }
        public DateTime ServiceDate { get; set; }
        public bool ChainChange { get; set; }
        public bool BrakeFluidChange { get; set; }
        public bool OilChange { get; set; }
        public bool AirFilterChange { get; set; }
    }
}
