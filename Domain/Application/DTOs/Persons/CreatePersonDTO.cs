using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Persons
{
    public class CreatePersonDTO
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LasttName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
    }
}
