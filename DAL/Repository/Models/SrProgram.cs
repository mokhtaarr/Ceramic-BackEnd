using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_Programs")]
    public partial class SrProgram
    {
        public SrProgram()
        {
            SrTripProgramJoins = new HashSet<SrTripProgramJoin>();
        }

        [Key]
        public int ProgramId { get; set; }
        [StringLength(50)]
        public string? ProgramCode { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [StringLength(50)]
        public string? Days { get; set; }
        [Column("MTSCruze")]
        [StringLength(50)]
        public string? Mtscruze { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [InverseProperty("Program")]
        public virtual ICollection<SrTripProgramJoin> SrTripProgramJoins { get; set; }
    }
}
