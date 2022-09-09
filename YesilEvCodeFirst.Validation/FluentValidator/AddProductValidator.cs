using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddProductValidator : AbstractValidator<AddProductDTO>
    {
        public AddProductValidator()
        {
            #region Category Validator Product Page
            //Category validator for Product Page
            RuleFor(x => x.CategoryID).GreaterThan(0).WithMessage(ValidationMessages.CategoryIDNull);
            #endregion

            #region Supplier Validator Product Page
            //Supplier validator for Product Page
            RuleFor(x => x.SupplierID).GreaterThan(0).WithMessage(ValidationMessages.SupplierIDNull);
            #endregion

            #region Product Validator Product Page
            //Product validator for Product Page
            RuleFor(x => x.ProductName).NotEmpty().WithMessage(ValidationMessages.ProductNameIsEmpty);
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage(ValidationMessages.ProductNameMinLength);
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage(ValidationMessages.ProductNameMaxLength);
            #endregion

            #region Barcode Validator Product Page
            //Barcode validator for Product Page
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(ValidationMessages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(ValidationMessages.BarcodeMaxLength);
            #endregion

            #region ProductContent Validator Product Page
            //Product validator for Product Page
            RuleFor(x => x.ProductContent).NotEmpty().WithMessage(ValidationMessages.ProductContentIsEmpty);
            #endregion
        }
    }
}
