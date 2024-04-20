namespace StoreApi.Dtos
{
    public class ComplaintDto
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ComDesc { get; set; }

        public IFormFile Image { get; set; }



    }
}
