using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.Category;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddCategoryValidator : AbstractValidator<AddCategoryDTO>
    {
        public AddCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage(ValidationMessages.CategoryNameEmpty);
            RuleFor(x => x.CategoryName).MaximumLength(100).WithMessage(ValidationMessages.CategoryNameMaxLength);
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage(ValidationMessages.CategoryNameMinLength);

            RuleFor(x => x.UstCategoryID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
        }
    }
}
