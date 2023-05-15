using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwAccountClassification
    {
        public long? Code { get; set; }
        [StringLength(100)]
        public string? DescA { get; set; }
        [StringLength(100)]
        public string? DescE { get; set; }
        [StringLength(17)]
        [Unicode(false)]
        public string? ClassLevel { get; set; }
        public long? AccountCatCode { get; set; }
        [StringLength(100)]
        public string? AccountCatDescA { get; set; }
        [StringLength(100)]
        public string? AccountCatDescE { get; set; }
        public byte? AccountClassType { get; set; }
    }
}
