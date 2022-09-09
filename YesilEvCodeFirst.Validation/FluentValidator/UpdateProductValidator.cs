using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductDTO>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.CategoryID).GreaterThan(0).WithMessage(ValidationMessages.CategoryIDNull);
            RuleFor(x => x.SupplierID).GreaterThan(0).WithMessage(ValidationMessages.SupplierIDNull);

            RuleFor(x => x.ProductName).NotEmpty().WithMessage(ValidationMessages.ProductNameIsEmpty);
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage(ValidationMessages.ProductNameMinLength);
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage(ValidationMessages.ProductNameMaxLength);


            RuleFor(x => x.Barcode).NotEmpty().WithMessage(ValidationMessages.BarcodeIsEmpty);
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(ValidationMessages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(ValidationMessages.BarcodeMaxLength);

            RuleFor(x => x.ProductContent).NotEmpty().WithMessage(ValidationMessages.ProductContentIsEmpty);
        }
    }
}
