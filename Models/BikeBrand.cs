using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class BikeBrand
    {
        public BikeBrand()
        {
            BikeModels = new HashSet<BikeModel>();
        }
        public int BikeBrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BikeModel> BikeModels { get; set; }
    }
}
