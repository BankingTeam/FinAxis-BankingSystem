using FinAxis.Api.Dtos;

namespace FinAxis.Api.Entities;

public class User : UserSignUpDTO
{
    public int Id { get; set; }
    public DateOnly AccountCreatedAt { get; set; } =  DateOnly.FromDateTime(DateTime.Today);
}
