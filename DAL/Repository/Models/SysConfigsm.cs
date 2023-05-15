using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("sys_configsms")]
    public partial class SysConfigsm
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("namesrvices")]
        [StringLength(50)]
        public string? Namesrvices { get; set; }
        [Column("pasth")]
        [StringLength(500)]
        public string? Pasth { get; set; }
        [Column("keeey")]
        [StringLength(500)]
        public string? Keeey { get; set; }
        [Column("sender")]
        [StringLength(50)]
        public string? Sender { get; set; }
        [Column("code")]
        public int? Code { get; set; }
    }
}
