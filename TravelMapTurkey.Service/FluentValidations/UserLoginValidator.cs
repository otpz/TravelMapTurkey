using FluentValidation;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.FluentValidations
{
    public class UserLoginValidator : AbstractValidator<UserLoginViewModel>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .EmailAddress();
        }
    }
}
