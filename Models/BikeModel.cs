using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class BikeModel
    {

        public int BikeModelId { get; set; }
        public string Name { get; set; }
        public int LastSupportedYear { get; set; }
        public int BikeBrandId { get; set; }

        public virtual BikeBrand BikeBrand { get; set; }
    }
}
