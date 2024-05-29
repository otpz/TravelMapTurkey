using FluentValidation;
using TravelMapTurkey.Entity.ViewModel.Cities;

namespace TravelMapTurkey.Service.FluentValidations
{
    public class CityAddValidator : AbstractValidator<CityAddViewModel>
    {
        public CityAddValidator()
        {
            RuleFor(x => x.CityName)
                .NotNull()
                .WithName("Şehir ismi");

            RuleFor(x => x.Review)
                .MaximumLength(500)
                .WithName("Açıklama");

            RuleFor(x => x.Type)
                .NotNull()
                .WithName("Tip");
        }
    }
}
