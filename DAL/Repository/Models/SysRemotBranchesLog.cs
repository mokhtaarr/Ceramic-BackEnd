using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Sys_RemotBranchesLog")]
    public partial class SysRemotBranchesLog
    {
        public SysRemotBranchesLog()
        {
            SysRemoteBranchesLogDetailes = new HashSet<SysRemoteBranchesLogDetaile>();
        }

        [Key]
        public long LogId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LogTime { get; set; }
        public int? StoreId { get; set; }
        /// <summary>
        /// 1 insert,2 update,3 delete
        /// </summary>
        public byte? LogType { get; set; }
        public int? UserId { get; set; }
        public byte[]? LogTimStamp { get; set; }
        public bool? RemotExecuted { get; set; }
        public bool? IsMasterFile { get; set; }

        [InverseProperty("Log")]
        public virtual ICollection<SysRemoteBranchesLogDetaile> SysRemoteBranchesLogDetailes { get; set; }
    }
}
