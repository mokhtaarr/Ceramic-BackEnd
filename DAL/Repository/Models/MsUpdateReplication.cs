using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_UpdateReplication")]
    public partial class MsUpdateReplication
    {
        [Key]
        [Column("UpdatID")]
        public int UpdatId { get; set; }
        [StringLength(100)]
        public string? TableDef { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastUpDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate2 { get; set; }
        [StringLength(100)]
        public string? LastUpdate3 { get; set; }
    }
}
