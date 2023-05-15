using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sr_JobComments")]
    public partial class SrJobComment
    {
        [Key]
        public int JobComentId { get; set; }
        public int? JorderId { get; set; }
        public int? EmpIdComBy { get; set; }
        [StringLength(500)]
        public string? Comment { get; set; }

        [ForeignKey("JorderId")]
        [InverseProperty("SrJobComments")]
        public virtual SrJobOrder? Jorder { get; set; }
    }
}
