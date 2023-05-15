using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_ReciptionDetail")]
    public partial class SrReciptionDetail
    {
        [Key]
        public int RecipDetlId { get; set; }
        public int? ReciptionId { get; set; }
        [StringLength(250)]
        public string? CustRequest { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [Column("ComID")]
        public int? ComId { get; set; }
        public byte? Serial { get; set; }

        [ForeignKey("ComId")]
        [InverseProperty("SrReciptionDetails")]
        public virtual SrComplaint? Com { get; set; }
        [ForeignKey("ReciptionId")]
        [InverseProperty("SrReciptionDetails")]
        public virtual SrReciption? Reciption { get; set; }
    }
}
