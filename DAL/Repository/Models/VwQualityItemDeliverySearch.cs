using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwQualityItemDeliverySearch
    {
        public int TrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(50)]
        public string? CustomerCode { get; set; }
        [StringLength(100)]
        public string? CustomerDescA { get; set; }
        public int? StoreId { get; set; }
        public int? TotalPieces { get; set; }
        public bool Executed { get; set; }
        [StringLength(151)]
        public string? DocTrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        public int ItemDeliverId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        [StringLength(50)]
        public string? CurrencyCode { get; set; }
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? TermCode { get; set; }
        [StringLength(100)]
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public bool IsPos { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField1 { get; set; }
        [StringLength(100)]
        public string? AddField2 { get; set; }
        [StringLength(50)]
        public string? EmpCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? ShiftCode { get; set; }
        [StringLength(100)]
        public string? ShiftsName1 { get; set; }
        [StringLength(100)]
        public string? ShiftsName2 { get; set; }
        [StringLength(50)]
        public string? StoreCode { get; set; }
        [StringLength(100)]
        public string? StoreDescA { get; set; }
        [StringLength(100)]
        public string? StoreDescE { get; set; }
        [StringLength(200)]
        public string? DocBarCode { get; set; }
        public int? PackageCount { get; set; }
        [StringLength(200)]
        public string? ItemRecCheckDocBarCode { get; set; }
        public int? ItemRecCheckPackageCount { get; set; }
        public int? ItemRecQualityId { get; set; }
        [StringLength(151)]
        public string? ItemRecCheckDocTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ItemRecCheckTrDate { get; set; }
        public int? ItemRecCheckBookId { get; set; }
        public int? ItemRecCheckTermId { get; set; }
        [StringLength(50)]
        public string? ItemRecCheckEmpCode { get; set; }
        [StringLength(100)]
        public string? ItemRecCheckEmpName1 { get; set; }
        [StringLength(100)]
        public string? ItemRecCheckEmpName2 { get; set; }
    }
}
