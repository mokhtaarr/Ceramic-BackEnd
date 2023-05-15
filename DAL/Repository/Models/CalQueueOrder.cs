using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_QueueOrder")]
    public partial class CalQueueOrder
    {
        [Key]
        public int OrderId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public int? QueueOrder { get; set; }
    }
}
