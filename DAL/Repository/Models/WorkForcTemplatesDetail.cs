using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("WorkForc_TemplatesDetails")]
    public partial class WorkForcTemplatesDetail
    {
        [Key]
        [Column("WFTempDetailId")]
        public int WftempDetailId { get; set; }
        [Column("WFTempId")]
        public int WftempId { get; set; }
        [Column("WFPassPortId")]
        public int? WfpassPortId { get; set; }

        [ForeignKey("WftempId")]
        [InverseProperty("WorkForcTemplatesDetails")]
        public virtual WorkForcTemplate Wftemp { get; set; } = null!;
    }
}
