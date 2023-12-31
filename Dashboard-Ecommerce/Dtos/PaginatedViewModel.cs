namespace Dashboard_Ecommerce.Dtos
{
    public class PaginatedViewModel<T>
    {
        public List<OrderDataDto> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}
