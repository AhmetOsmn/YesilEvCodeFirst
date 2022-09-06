using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetProductDetailWithBarcodeValidator : AbstractValidator<BarcodeDTO>
    {
        public GetProductDetailWithBarcodeValidator()
        {
            #region Search Barcode Validation Barcode Page
            //Bracode validation for Barcode Page
            RuleFor(x => x.Barcode).NotEmpty().WithMessage(Messages.BarcodeIsEmpty);
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(Messages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(Messages.BarcodeMaxLength);
            #endregion
        }
    }
}
