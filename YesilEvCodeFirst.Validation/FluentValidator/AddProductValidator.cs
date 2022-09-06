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
            RuleFor(x => x.CategoryID).GreaterThan(0).WithMessage(Messages.CategoryIDNull);
            #endregion

            #region Supplier Validator Product Page
            //Supplier validator for Product Page
            RuleFor(x => x.SupplierID).GreaterThan(0).WithMessage(Messages.SupplierIDNull);
            #endregion

            #region Product Validator Product Page
            //Product validator for Product Page
            RuleFor(x => x.ProductName).NotEmpty().WithMessage(Messages.ProductNameIsEmpty);
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage(Messages.ProductNameMinLength);
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage(Messages.ProductNameMaxLength);
            #endregion

            #region Barcode Validator Product Page
            //Barcode validator for Product Page
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(Messages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(Messages.BarcodeMaxLength);
            #endregion

            #region ProductContent Validator Product Page
            //Product validator for Product Page
            RuleFor(x => x.ProductContent).NotEmpty().WithMessage(Messages.ProductContentIsEmpty);
            #endregion
        }
    }
}
