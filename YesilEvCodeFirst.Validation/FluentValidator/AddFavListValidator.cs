using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddFavListValidator : AbstractValidator<AddFavListDTO>
    {
        public AddFavListValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);

            RuleFor(x => x.FavoriListName).NotEmpty().WithMessage(ValidationMessages.ListNameIsEmpty);
            RuleFor(x => x.FavoriListName).MinimumLength(2).WithMessage(ValidationMessages.ListNameMinLength);
            RuleFor(x => x.FavoriListName).MaximumLength(50).WithMessage(ValidationMessages.ListNameMaxLength);
        }
    }
}
