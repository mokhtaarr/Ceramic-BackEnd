using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_AccountClaasiJoin")]
    public partial class CalAccountClaasiJoin
    {
        [Key]
        public int AcChrtJoinClaasi { get; set; }
        public int? AccountId { get; set; }
        public int? AccountClassId { get; set; }
        public byte? Operator { get; set; }
        public int? DaysCount { get; set; }
        public byte? TypeOfAcc { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("CalAccountClaasiJoins")]
        public virtual CalAccountChart? Account { get; set; }
    }
}
