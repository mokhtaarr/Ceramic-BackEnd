using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_UserAuthentications")]
    public partial class MsUserAuthentication
    {
        [Key]
        public int AuthId { get; set; }
        public int? UserId { get; set; }
        [StringLength(50)]
        public string? AuthCode { get; set; }
        [StringLength(100)]
        public string? AuthName { get; set; }
        [StringLength(100)]
        public string? AuthDesc { get; set; }
        public bool? Authinticated { get; set; }
        /// <summary>
        /// the Id of the user who athurized to give this authentication
        /// </summary>
        public int? AuthenticatedBy { get; set; }
    }
}
