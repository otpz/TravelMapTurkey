using FluentValidation;
using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.FluentValidations
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateViewModel>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(40)
                .WithName("İsim");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(40)
                .WithName("Soyisim");

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .WithName("Email");

            RuleFor(x => x.Biography)
                .MaximumLength(500)
                .WithName("Biyografi");
        }
    }
}
