﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwQualityItemDeliverySearch
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerDescA { get; set; }
        public int? StoreId { get; set; }
        public int? TotalPieces { get; set; }
        public bool Executed { get; set; }
        public string DocTrNo { get; set; }
        public string ManualTrNo { get; set; }
        public int ItemDeliverId { get; set; }
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyDescA { get; set; }
        public string CurrencyDescE { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string TermCode { get; set; }
        public string TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public bool IsPos { get; set; }
        public string DeletedBy { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public string AddField5 { get; set; }
        public string AddField1 { get; set; }
        public string AddField2 { get; set; }
        public string EmpCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string ShiftCode { get; set; }
        public string ShiftsName1 { get; set; }
        public string ShiftsName2 { get; set; }
        public string StoreCode { get; set; }
        public string StoreDescA { get; set; }
        public string StoreDescE { get; set; }
        public string DocBarCode { get; set; }
        public int? PackageCount { get; set; }
        public string ItemRecCheckDocBarCode { get; set; }
        public int? ItemRecCheckPackageCount { get; set; }
        public int? ItemRecQualityId { get; set; }
        public string ItemRecCheckDocTrNo { get; set; }
        public DateTime? ItemRecCheckTrDate { get; set; }
        public int? ItemRecCheckBookId { get; set; }
        public int? ItemRecCheckTermId { get; set; }
        public string ItemRecCheckEmpCode { get; set; }
        public string ItemRecCheckEmpName1 { get; set; }
        public string ItemRecCheckEmpName2 { get; set; }
    }
}