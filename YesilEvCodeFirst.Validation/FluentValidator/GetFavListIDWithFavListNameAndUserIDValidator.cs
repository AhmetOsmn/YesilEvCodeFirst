using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetFavListIDWithFavListNameAndUserIDValidator : AbstractValidator<GetFavListIDWithFavListNameAndUserIDDTO>
    {
        public GetFavListIDWithFavListNameAndUserIDValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);

            RuleFor(x => x.FavListName).NotEmpty().WithMessage(ValidationMessages.ListNameIsEmpty);
            RuleFor(x => x.FavListName).MinimumLength(2).WithMessage(ValidationMessages.ListNameMinLength);
            RuleFor(x => x.FavListName).MaximumLength(50).WithMessage(ValidationMessages.ListNameMaxLength);
        }
    }
}
