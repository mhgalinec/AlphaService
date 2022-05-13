using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Models
{
    public partial class User
    {

        public User()
        {
            UserOrderRelationship = new HashSet<UserOrderRelationship>();
        }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserOrderRelationship> UserOrderRelationship { get; set; }
    }
}
