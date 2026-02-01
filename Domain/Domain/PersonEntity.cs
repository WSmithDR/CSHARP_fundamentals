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
    }
}
