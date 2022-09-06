using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddProductValidator : AbstractValidator<AddProductDTO>
    {
        public AddProductValidator()
        {
            RuleFor(x => x.CategoryID).GreaterThan(0).WithMessage(Messages.CategoryIDNull);
            RuleFor(x => x.SupplierID).GreaterThan(0).WithMessage(Messages.SupplierIDNull);

            RuleFor(x => x.ProductName).NotEmpty().WithMessage(Messages.ProductNameIsEmpty);
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage(Messages.ProductNameMinLength);
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage(Messages.ProductNameMaxLength);

            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(Messages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(Messages.BarcodeMaxLength);

            RuleFor(x => x.ProductContent).NotEmpty().WithMessage(Messages.ProductContentIsEmpty);
        }
    }
}
