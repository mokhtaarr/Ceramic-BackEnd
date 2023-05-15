using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Keyless]
    public partial class VwGetBankNoticeRank
    {
        public long? RowRank { get; set; }
        public int BankNoticId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
