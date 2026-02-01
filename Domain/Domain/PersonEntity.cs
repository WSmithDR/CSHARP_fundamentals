namespace Domain
{
    public class PersonEntity
    {
        public Guid Id { get; private set; }
        public string Code { get; private set; } = string.Empty;
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;

        public PersonEntity(String code, String firstName, String lastName, String email, String phoneNumber)
        {
            Id = Guid.NewGuid();
            Code = code.Trim().ToUpper();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber.Trim();
        }

        private void ValidateCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code)){
                throw new ArgumentException("No puedes proporcionar un codigo nulo o solo de espacios en blanco", nameof(code));
            }

            if(code.Length<3 || code.Length > 20){
                throw new ArgumentException("El codigo solo puede tener entre 3 y 20 caracteres", nameof(code));
            }
        }
      
    }
}
