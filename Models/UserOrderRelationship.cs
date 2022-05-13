using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class UserOrderRelationship
    {
        public int UserOrderRelationshipId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }


        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
    }
}
