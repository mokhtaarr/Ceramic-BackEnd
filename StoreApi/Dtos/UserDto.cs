﻿namespace StoreApi.Dtos
{
    public class UserDto
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Token { get; set; }

        public string Message { get; set; } 
        public string MessageEn { get; set; }
        public bool statu { get; set; }
    }
}
