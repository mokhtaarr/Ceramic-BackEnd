using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("SysRemoteBranchesLogDetaile")]
    public partial class SysRemoteBranchesLogDetaile
    {
        [Key]
        public long LogDetailId { get; set; }
        public long? LogId { get; set; }
        [StringLength(100)]
        public string? FieldName { get; set; }
        /// <summary>
        /// 1 insert,2 update,3 delete,4 print, preview
        /// </summary>
        public byte? LogType { get; set; }
        [StringLength(200)]
        public string? FieldOldValue { get; set; }
        [StringLength(200)]
        public string? FieldNewValue { get; set; }

        [ForeignKey("LogId")]
        [InverseProperty("SysRemoteBranchesLogDetailes")]
        public virtual SysRemotBranchesLog? Log { get; set; }
    }
}
