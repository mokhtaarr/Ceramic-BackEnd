﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_PurchasInvoiceMultiAccounts")]
    public partial class MsPurchasInvoiceMultiAccount
    {
        [Key]
        public int PurMultiAccountId { get; set; }
        public int? PurInvId { get; set; }
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

        [ForeignKey("PurInvId")]
        [InverseProperty("MsPurchasInvoiceMultiAccounts")]
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}