using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    public partial class Name
    {
        [Key]
        public int Id { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
    }
}
