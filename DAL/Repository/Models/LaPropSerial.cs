using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("La_PropSerial")]
    public partial class LaPropSerial
    {
        [Key]
        public int PropId { get; set; }
        public int? CustMain { get; set; }
        public int? CustProp { get; set; }
        public int? LandId { get; set; }

        [ForeignKey("CustMain")]
        [InverseProperty("LaPropSerials")]
        public virtual MsCustomer? CustMainNavigation { get; set; }
    }
}
