using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Stock_TranTypes")]
    public partial class StockTranType
    {
        [Key]
        public int StockTranTypId { get; set; }
        public byte? TermType { get; set; }
        public int? BookId { get; set; }
        [StringLength(50)]
        public string? Code { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        /// <summary>
        /// 1 Plus, 2 Minus, 3 Without
        /// </summary>
        public byte? StockEffect { get; set; }
        /// <summary>
        /// 1 Plus, 2 Minus, 3 Without
        /// </summary>
        public byte? CashEffect1 { get; set; }
        public int? TermId { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }
}
