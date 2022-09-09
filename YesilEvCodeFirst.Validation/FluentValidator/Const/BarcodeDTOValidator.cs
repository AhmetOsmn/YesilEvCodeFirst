using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator.Const
{
    public class BarcodeDTOValidator : AbstractValidator<BarcodeDTO>
    {
        public BarcodeDTOValidator()
        {
            RuleFor(x => x.Barcode).NotEmpty().WithMessage(ValidationMessages.BarcodeIsEmpty);
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(ValidationMessages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(ValidationMessages.BarcodeMaxLength);
        }
    }
}
