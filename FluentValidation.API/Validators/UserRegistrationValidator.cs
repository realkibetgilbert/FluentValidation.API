using FluentValidation.API.Dtos;

namespace FluentValidation.API.Validators
{
    public class UserRegistrationValidator : AbstractValidator<UserRegistrationDto>
    {
        public UserRegistrationValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.LastName).NotEmpty().MaximumLength(10);
            RuleFor(x => x.Email).EmailAddress().WithMessage("{PropertyName} is invalid ! please check");
            RuleFor(x=>x.Password).Equal(z=>z.ConfirmPassword).WithMessage("Passwords do not match");
        }
    }
}
