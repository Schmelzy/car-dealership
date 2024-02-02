using CarDealership.Models.Requests;
using FluentValidation;

namespace CarDealership.Validators
{
    public class TestRequestValidator : AbstractValidator<TestRequest>
    {
        public TestRequestValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(20);
        }
    }
}
