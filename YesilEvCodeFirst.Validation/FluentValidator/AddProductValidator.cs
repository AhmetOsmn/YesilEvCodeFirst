using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddProductValidator : AbstractValidator<AddProductDTO>
    {
        public AddProductValidator()
        {
            #region Category Validation Add Product Page
            //Category validaton for Add Product Page
            RuleFor(x => x.CategoryID).NotNull().WithMessage(Messages.CategoryNameIsEmpty);
            RuleFor(x => x.CategoryID).GreaterThan(0).WithMessage(Messages.InvalidID);
            #endregion

            #region Supplier Validation Add Product Page
            //Supplier validation for Add Product Page
            RuleFor(x => x.SupplierID).GreaterThan(0).WithMessage(Messages.InvalidID);
            #endregion

            #region Product Validation Add Product Page
            //Product validation Add Product Page
            RuleFor(x => x.ProductName).NotEmpty().WithMessage(Messages.ProductNameIsEmpty);
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage(Messages.ProductNameMinLength);
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage(Messages.ProductNameMaxLength);
            #endregion

            #region Barcode Validation Add Product Page
            //Barcode validation Add Product Page
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(Messages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(Messages.BarcodeMaxLength);
            #endregion

            #region Product Content Validation Add Product Page
            //PRoduct validation Add Product Page
            RuleFor(x => x.ProductContent).NotEmpty().WithMessage(Messages.ProductContentIsEmpty);
            #endregion
        }
    }
}
