using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator.Const
{
    public class BarcodeDTOValidator : AbstractValidator<BarcodeDTO>
    {
        public BarcodeDTOValidator()
        {
            RuleFor(x => x.Barcode).NotEmpty().WithMessage(Messages.BarcodeIsEmpty);
            RuleFor(x => x.Barcode).MinimumLength(7).WithMessage(Messages.BarcodeMinLength);
            RuleFor(x => x.Barcode).MaximumLength(50).WithMessage(Messages.BarcodeMaxLength);
        }
    }
}
