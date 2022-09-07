using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddSupplierValidator : AbstractValidator<AddSupplierDTO>
    {
        public AddSupplierValidator()
        {
            RuleFor(x => x.SupplierName).NotEmpty().WithMessage(Messages.SupplierNameEmpty);
            RuleFor(x => x.SupplierName).MinimumLength(2).WithMessage(Messages.SupplierNameMinLength);
            RuleFor(x => x.SupplierName).MaximumLength(100).WithMessage(Messages.SupplierNameMaxLength);
        }
    }
}
