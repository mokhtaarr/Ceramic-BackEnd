using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Identity
{
    public class AppUser:IdentityUser
    {
        public string DisplayName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Address Address { get; set; }


    }
}
