using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Cal_AccChrtDailyAssist")]
    public partial class CalAccChrtDailyAssist
    {
        [Key]
        public int AccChrtDailyAssistId { get; set; }
        public int? AccountId { get; set; }
        public int? DailyAssisId { get; set; }

        [ForeignKey("AccountId")]
        [InverseProperty("CalAccChrtDailyAssists")]
        public virtual CalAccountChart? Account { get; set; }
    }
}
