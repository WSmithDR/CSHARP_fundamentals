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
            ValidateCode(code);
            ValidateFirstName(firstName);
            ValidateLastName(lastName);

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

        private void ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName){
                throw new ArgumentException("El nombre no puede estar vacio", nameof(firstName))
            }

            if(firstName.Length < 2 || firstName.Length > 50)
            {
                throw new ArgumentException("El nombre no puede tener menos de 2 carcteres y mas 50", nameof(firstName));
            }
        }

        private void ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName){
                throw new ArgumentException("El apellido no puede estar vacio", nameof(lastName))
            }

            if (firstName.Length < 2 || firstName.Length > 50)
            {
                throw new ArgumentException("El apellido no puede tener menos de 2 carcteres y mas 50", nameof(lastName));
            }
        }

        private void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email){
                throw new ArgumentException("El correo no puede estar vacio", nameof(email))
            }

            if (email.Length > 100)
            {
                throw new ArgumentException("El correo no puede tener mas de 100 caracteres", nameof(email));
            }
        }

    }
}
