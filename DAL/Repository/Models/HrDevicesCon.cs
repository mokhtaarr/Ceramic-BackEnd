using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_DevicesCon")]
    public partial class HrDevicesCon
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("ip", TypeName = "text")]
        public string? Ip { get; set; }
        [Column("port", TypeName = "text")]
        public string? Port { get; set; }
        [Column("keycomm", TypeName = "text")]
        public string? Keycomm { get; set; }
        [Column("namedev")]
        [StringLength(50)]
        public string? Namedev { get; set; }
    }
}
