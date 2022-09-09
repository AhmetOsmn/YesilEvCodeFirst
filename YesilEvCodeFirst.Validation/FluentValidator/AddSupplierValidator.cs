using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddSupplierValidator : AbstractValidator<AddSupplierDTO>
    {
        public AddSupplierValidator()
        {
            RuleFor(x => x.SupplierName).NotEmpty().WithMessage(ValidationMessages.SupplierNameEmpty);
            RuleFor(x => x.SupplierName).MinimumLength(2).WithMessage(ValidationMessages.SupplierNameMinLength);
            RuleFor(x => x.SupplierName).MaximumLength(100).WithMessage(ValidationMessages.SupplierNameMaxLength);
        }
    }
}
