using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ReturnPurchaseMultiAccounts")]
    public partial class MsReturnPurchaseMultiAccount
    {
        [Key]
        public int RetPurMultiAccountId { get; set; }
        public int? RetPurchId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableName")]
        [StringLength(100)]
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [Column("DBTableId")]
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        [StringLength(100)]
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        public int? RectSourceTypeId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? RectSourceBalance { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? CostCenterId4 { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditCurrency { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? DebitLocal { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? CreditLocal { get; set; }
        [StringLength(100)]
        public string? Remarks { get; set; }

        [ForeignKey("RetPurchId")]
        [InverseProperty("MsReturnPurchaseMultiAccounts")]
        public virtual MsReturnPurchase? RetPurch { get; set; }
    }
}
