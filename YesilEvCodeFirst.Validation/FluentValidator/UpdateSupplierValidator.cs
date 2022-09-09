using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateSupplierValidator : AbstractValidator<UpdateSupplierDTO>
    {
        public UpdateSupplierValidator()
        {
            RuleFor(x => x.SupplierName).NotEmpty().WithMessage("Eski " + ValidationMessages.SupplierNameEmpty);
            RuleFor(x => x.SupplierName).MinimumLength(2).WithMessage("Eski " + ValidationMessages.SupplierNameMinLength);
            RuleFor(x => x.SupplierName).MaximumLength(100).WithMessage("Eski " + ValidationMessages.SupplierNameMaxLength);

            RuleFor(x => x.SupplierNewName).NotEmpty().WithMessage("Yeni " + ValidationMessages.SupplierNameEmpty);
            RuleFor(x => x.SupplierNewName).MinimumLength(2).WithMessage("Yeni " + ValidationMessages.SupplierNameMinLength);
            RuleFor(x => x.SupplierNewName).MaximumLength(100).WithMessage("Yeni " + ValidationMessages.SupplierNameMaxLength);
        }
    }
}
