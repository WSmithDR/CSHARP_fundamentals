using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Persons
{
    public class UpdatePersonDTO
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Cellphone { get; private set; } = string.Empty;
    }
}
