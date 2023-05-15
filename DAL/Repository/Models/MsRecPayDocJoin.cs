using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_RecPayDocJoin")]
    public partial class MsRecPayDocJoin
    {
        [Key]
        public int InvRecPayId { get; set; }
        public int? PayId { get; set; }
        public int? RectId { get; set; }
        public int? DocId { get; set; }
        public byte? DocType { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Paid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? NotPaid { get; set; }
    }
}
