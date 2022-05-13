using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int ModelId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string OilPrice { get; set; }
        public string ChainPrice { get; set; }
        public string AirFilterPrice { get; set; }
        public string BrakeFluidPrice { get; set; }
        public string FullPrice { get; set; }
        public string FinalPrice { get; set; }
        public string Discount { get; set; }
    }
}
