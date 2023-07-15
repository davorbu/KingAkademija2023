using Api.DTO;
using FluentValidation;

namespace Api
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(user => user.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Last name is required");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email is not valid");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(user => user.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters long");
            RuleFor(user => user.RoleId).NotNull().WithMessage("RoleId is required");
        }
    }
}
