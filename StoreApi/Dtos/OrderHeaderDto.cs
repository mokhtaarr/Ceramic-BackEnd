namespace StoreApi.Dtos
{
    public class OrderHeaderDto
    {
        public int Header_BookId { get; set; }
        public int Header_TermId { get; set; }
        public int Header_CurrencyId { get; set; }
        public int Header_CustomerId { get; set; }
        public string Header_CreatedBy { get; set; }

        public DateTime Header_CreatedAt { get; set; }
        public decimal Header_NotPaid { get; set; }

        public int? Header_TaxesId1 { get; set; }
        public int? Header_TaxesId2 { get; set; }
        public int? Header_TaxesId3 { get; set; }

        public OrderDetail[] OrderDetails { get; set; }


        //public DateTime InvDueDate { get; set; }
        //public int Header_RectSourceType { get; set; }
        //public int InvoiceType { get; set; }
        //public decimal Header_Rate { get; set; }
        //public decimal Header_InvTotal { get; set; }
        //public decimal Header_DiscAmount { get; set; }
        //public decimal Header_DiscPercent { get; set; }
        //public decimal Header_DiscAmount2 { get; set; }
        //public decimal Header_DiscPercent2 { get; set; }
        //public decimal Header_TotalItemTax1 { get; set; }
        //public decimal Header_TotalItemTax2 { get; set; }
        //public decimal Header_TotalItemTax3 { get; set; }
        //public decimal Header_TaxValue1 { get; set; }
        //public decimal Header_TaxValue2 { get; set; }
        //public decimal Header_TaxValue3 { get; set; }
        //public decimal Header_PriceAfterTax { get; set; }
        //public decimal Header_NetPrice { get; set; }
        //public decimal Header_PaidPrice { get; set; }
        //public decimal Header_PaidPriceVisa { get; set; }
        //public string Remarks { get; set; }
        //public string AddField3 { get; set; }
        //public int StoreId { get; set; }
        //public decimal ExpenValue { get; set; }
    }

    public class OrderDetail
    {
        public int ItemCardId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public int? Detail_TaxesId1 { get; set; }
        public int? Detail_TaxesId2 { get; set; }
        public int? Detail_TaxesId3 { get; set; }
        public bool? Tax1IsAccomulative { get; set; }
        public bool? Tax2IsAccomulative { get; set; }
        public bool? Tax3IsAccomulative { get; set; }

        //public int SalesOfferId { get; set; }
        //public bool IsCollection { get; set; }
        //public decimal PriceAfterRate { get; set; }
        //public decimal QtyBeforRate { get; set; }
        //public int UnitId { get; set; }
        //public decimal UnitRate { get; set; }
        //public int StoreId { get; set; }
        //public int StorePartId { get; set; }
        //public decimal DisPercent { get; set; }
        //public decimal DisAmount { get; set; }
        //public decimal Tax1Percent { get; set; }
        //public decimal Tax2Percent { get; set; }
        //public decimal Tax3Percent { get; set; }


    }
}
