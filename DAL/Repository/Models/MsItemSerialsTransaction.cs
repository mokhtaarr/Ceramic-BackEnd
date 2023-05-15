using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("MS_ItemSerialsTransactions")]
    public partial class MsItemSerialsTransaction
    {
        [Key]
        public int ItemSerialTranId { get; set; }
        public int? ItemSerialId { get; set; }
        [StringLength(100)]
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public bool? IsInOrOut { get; set; }
        public int? StorePartId { get; set; }
    }
}
