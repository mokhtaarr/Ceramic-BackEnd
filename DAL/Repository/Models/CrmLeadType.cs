using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("CRM_LeadTypes")]
    public partial class CrmLeadType
    {
        public CrmLeadType()
        {
            CrmLeads = new HashSet<CrmLead>();
        }

        [Key]
        public int LeadTypeId { get; set; }
        [StringLength(50)]
        public string? LeadTypeCode { get; set; }
        [StringLength(100)]
        public string? LeadTypeName1 { get; set; }
        [StringLength(100)]
        public string? LeadTypeName2 { get; set; }
        [StringLength(200)]
        public string? LeadTypeDes { get; set; }
        [StringLength(20)]
        public string? CreayedBy { get; set; }
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

        [InverseProperty("LeadType")]
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
    }
}
