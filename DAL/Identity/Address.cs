using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstNameAr { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameAr { get; set; }
        public string LastNameEn { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
