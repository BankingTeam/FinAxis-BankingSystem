using System.ComponentModel.DataAnnotations;

namespace FinAxis.Api.Dtos;

public class UserLoginDTO
{
    [Required]
    public string? PhoneOrEmail { get; set; }

    [Required]
    public string? Password { get; set; }
}