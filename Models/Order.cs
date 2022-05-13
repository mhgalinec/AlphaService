using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class Order
    {

        public Order()
        {
            UserOrderRelationship = new HashSet<UserOrderRelationship>();
        }

        public int OrderId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool ChainChange { get; set; }
        public bool BrakeFluidChange { get; set; }
        public bool OilChange { get; set; }
        public bool AirFilterChange { get; set; }
        public string Progress { get; set; }


        public virtual ICollection<UserOrderRelationship> UserOrderRelationship { get; set; }
    }
}
