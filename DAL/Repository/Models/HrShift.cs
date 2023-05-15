using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Hr_Shifts")]
    public partial class HrShift
    {
        public HrShift()
        {
            HrEmployees = new HashSet<HrEmployee>();
        }

        [Key]
        public int ShiftId { get; set; }
        [StringLength(50)]
        public string? ShiftCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? Day1Name1 { get; set; }
        [StringLength(50)]
        public string? Day1Name2 { get; set; }
        [StringLength(50)]
        public string? Day2Name1 { get; set; }
        [StringLength(50)]
        public string? Day2Name2 { get; set; }
        [StringLength(50)]
        public string? Day3Name1 { get; set; }
        [StringLength(50)]
        public string? Day3Name2 { get; set; }
        [StringLength(50)]
        public string? Day4Name1 { get; set; }
        [StringLength(50)]
        public string? Day4Name2 { get; set; }
        [StringLength(50)]
        public string? Day5Name1 { get; set; }
        [StringLength(50)]
        public string? Day5Name2 { get; set; }
        [StringLength(50)]
        public string? Day6Name1 { get; set; }
        [StringLength(50)]
        public string? Day6Name2 { get; set; }
        [StringLength(50)]
        public string? Day7Name1 { get; set; }
        [StringLength(50)]
        public string? Day7Name2 { get; set; }
        public bool? Day1Type { get; set; }
        public bool? Day2Type { get; set; }
        public bool? Day3Type { get; set; }
        public bool? Day4Type { get; set; }
        public bool? Day5Type { get; set; }
        public bool? Day6Type { get; set; }
        public bool? Day7Type { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShfDay1tFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay1To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay2From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay2To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay3From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay3To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay4From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay4To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay5From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay5To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay6From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay6To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay7From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? FirstShftDay7To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay1From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay1To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay2From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay2To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay3From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay3To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay4From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay4To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay5From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay5To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay6From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay6To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay7From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SecondShftDay7To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay1From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay1To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay2From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay2To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay3From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay3To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay4From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay4To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay5From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay5To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay6From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay6To { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay7From { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ThirdShftDay7To { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("Shift")]
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
    }
}
