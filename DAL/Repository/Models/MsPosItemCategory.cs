using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_PosItemCategory")]
    public partial class MsPosItemCategory
    {
        [Key]
        public int PosItemCategoryId { get; set; }
        public int? ItemCategoryId { get; set; }
        public bool? UseItemName { get; set; }
        public bool? UseItemImg { get; set; }
        public bool? UseItemCode { get; set; }
        public bool? UseItemBarcode { get; set; }
    }
}
