﻿namespace CRUD_API.Models
{
    public class AddStudenddto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
