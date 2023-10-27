using Business.Models.Request;
using FluentValidation;

namespace Business.Utilities.Validation;

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithName("Username ");
        RuleFor(x => x.Password).NotEmpty().WithName("Şifre");
    }
}