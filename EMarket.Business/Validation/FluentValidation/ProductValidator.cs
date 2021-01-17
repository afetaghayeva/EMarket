using Core.Business.Message;
using EMarket.Entity.Concrete;
using FluentValidation;

namespace EMarket.Business.Validation.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).Length(3, 20).NotEmpty().WithMessage(ErrorMessage.LengthMessage(3,20));
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage(ErrorMessage.GreaterThanZeroMessage);
            RuleFor(p => p.StockAmount).GreaterThanOrEqualTo((short)0).NotEmpty().WithMessage(ErrorMessage.GreaterThanZeroOrEqual);
            RuleFor(p => p.CategoryId).InclusiveBetween(1, 4).NotEmpty().WithMessage(ErrorMessage.LengthMessage(3, 20));
            //RuleFor(p => p.ProductName).Must(StartWithA).When(p=>p.CategoryId==1).WithMessage("Must be start with A");
        }

        private bool StartWithA(string arg)
        {
            return arg.ToLower().StartsWith("A");
        }
    }
}
