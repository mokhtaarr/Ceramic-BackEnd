using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_Currency")]
    public partial class MsCurrency
    {
        public MsCurrency()
        {
            CalJurnalDetails = new HashSet<CalJurnalDetail>();
            MsBoxCurrencies = new HashSet<MsBoxCurrency>();
            MsCurrencyCategoryJoins = new HashSet<MsCurrencyCategoryJoin>();
            MsCurrencyRates = new HashSet<MsCurrencyRate>();
            MsCustomers = new HashSet<MsCustomer>();
            MsVendors = new HashSet<MsVendor>();
        }

        [Key]
        public int CurrencyId { get; set; }
        [StringLength(50)]
        public string CurrencyCode { get; set; } = null!;
        [StringLength(100)]
        public string? CurrencyDescA { get; set; }
        [StringLength(100)]
        public string? CurrencyDescE { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? Rate { get; set; }
        public bool? DefualtCurrency { get; set; }
        [StringLength(50)]
        public string? CurrencySymbol { get; set; }
        [Column("fractionalUnit")]
        [StringLength(50)]
        public string? FractionalUnit { get; set; }
        public byte? DecimalPlaces { get; set; }
        public int? CurrencyCategoryId { get; set; }
        [StringLength(50)]
        public string? CurrenctType { get; set; }
        [Column("singleCurencyname")]
        [StringLength(100)]
        public string? SingleCurencyname { get; set; }
        [Column("singleCurencyname2")]
        [StringLength(100)]
        public string? SingleCurencyname2 { get; set; }
        [StringLength(100)]
        public string? DoubleCurencyname { get; set; }
        [StringLength(100)]
        public string? DoubleCurencyname2 { get; set; }
        [StringLength(100)]
        public string? CurrancyNameOverthree { get; set; }
        [StringLength(100)]
        public string? CurrancyNameOverthree2 { get; set; }
        [StringLength(100)]
        public string? CollectionCurrencyName { get; set; }
        [StringLength(100)]
        public string? CollectionCurrencyName2 { get; set; }
        [Column("singleCurencyFractionname")]
        [StringLength(100)]
        public string? SingleCurencyFractionname { get; set; }
        [Column("singleCurencyFractionname2")]
        [StringLength(100)]
        public string? SingleCurencyFractionname2 { get; set; }
        [StringLength(100)]
        public string? DoubleCurencyFractionname { get; set; }
        [StringLength(100)]
        public string? DoubleCurencyFractionname2 { get; set; }
        [StringLength(100)]
        public string? CurrancyNameFractionOverthree { get; set; }
        [StringLength(100)]
        public string? CurrancyNameFractionOverthree2 { get; set; }
        [StringLength(100)]
        public string? CollectionCurrencyFractionName { get; set; }
        [StringLength(100)]
        public string? CollectionCurrencyFractionName2 { get; set; }
        [Column("singleCurencyTempname")]
        [StringLength(100)]
        public string? SingleCurencyTempname { get; set; }
        [StringLength(100)]
        public string? DoubleCurencyTempname { get; set; }
        [StringLength(100)]
        public string? CurrancyNameTempOver3 { get; set; }
        [StringLength(100)]
        public string? CollectionCurrencyTempName { get; set; }
        public int? Aid { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? EquivalentConversionPrice { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModify { get; set; }
        [StringLength(50)]
        public string? EtaxUnitCode { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
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

        [InverseProperty("Currency")]
        public virtual ICollection<CalJurnalDetail> CalJurnalDetails { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<MsBoxCurrency> MsBoxCurrencies { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<MsCurrencyCategoryJoin> MsCurrencyCategoryJoins { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<MsCurrencyRate> MsCurrencyRates { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<MsCustomer> MsCustomers { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<MsVendor> MsVendors { get; set; }
    }
}
