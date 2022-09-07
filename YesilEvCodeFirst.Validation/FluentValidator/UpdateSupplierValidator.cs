using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateSupplierValidator : AbstractValidator<UpdateSupplierDTO>
    {
        public UpdateSupplierValidator()
        {
            RuleFor(x => x.SupplierName).NotEmpty().WithMessage("Eski " + Messages.SupplierNameEmpty);
            RuleFor(x => x.SupplierName).MinimumLength(2).WithMessage("Eski " + Messages.SupplierNameMinLength);
            RuleFor(x => x.SupplierName).MaximumLength(100).WithMessage("Eski " + Messages.SupplierNameMaxLength);

            RuleFor(x => x.SupplierNewName).NotEmpty().WithMessage("Yeni " + Messages.SupplierNameEmpty);
            RuleFor(x => x.SupplierNewName).MinimumLength(2).WithMessage("Yeni " + Messages.SupplierNameMinLength);
            RuleFor(x => x.SupplierNewName).MaximumLength(100).WithMessage("Yeni " + Messages.SupplierNameMaxLength);
        }
    }
}
