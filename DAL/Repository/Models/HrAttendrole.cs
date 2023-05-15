using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_attendrole")]
    public partial class HrAttendrole
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("satarttimeattdend")]
        public TimeSpan? Satarttimeattdend { get; set; }
        [Column("endstarttimeattend")]
        public TimeSpan? Endstarttimeattend { get; set; }
        [Column("starttimeatdepartur")]
        public TimeSpan? Starttimeatdepartur { get; set; }
        [Column("endtimeatdepartur")]
        public TimeSpan? Endtimeatdepartur { get; set; }
        [Column("nameshift")]
        [StringLength(50)]
        public string? Nameshift { get; set; }
    }
}
