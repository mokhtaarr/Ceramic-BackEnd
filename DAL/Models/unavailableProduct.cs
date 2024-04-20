using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UnavailableProduct
    {
        public int Id { get; set; }
        public string ProductNameAr { get; set; }
        public string ProductNameEn { get; set; }
        public string ProductDescA { get; set; }
        public string ProductDescE { get; set; }
        public decimal Price { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
