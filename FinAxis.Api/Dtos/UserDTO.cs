namespace FinAxis.Api.Dtos
{
    public class UserDTO
    {
        public string? FirstName { get;  }
        public string? LastName { get;  }
        public string? Email { get; }
        public string? PhoneNumber { get; }
        public DateOnly? DateOfBirth { get; }

    }
}
