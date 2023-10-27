using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request;

public class RegisterDto
{
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string Tc { get; set; } = default!;
    public string Address { get; set; } = default!;
    public UserType UserType { get; set; }
}