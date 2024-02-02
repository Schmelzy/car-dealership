using CarDealership.Models.Requests;
using FluentValidation;

namespace CarDealership.Validators
{
    public class GetAllCarsByManufacturerRequestValidator : AbstractValidator<GetAllCarsByManufacturerRequest>
    {
        public GetAllCarsByManufacturerRequestValidator() 
        {
            RuleFor(x => x.ManufacturerId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0).WithMessage("ManufacturerId must be > 0!");
        }
    }
}
