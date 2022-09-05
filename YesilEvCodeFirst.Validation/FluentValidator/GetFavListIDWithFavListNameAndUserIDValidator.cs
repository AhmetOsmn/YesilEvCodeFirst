using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetFavListIDWithFavListNameAndUserIDValidator : AbstractValidator<GetFavListIDWithFavListNameAndUserIDDTO>
    {
        public GetFavListIDWithFavListNameAndUserIDValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(Messages.InvalidID);

            RuleFor(x => x.FavListName).NotEmpty().WithMessage(Messages.ListNameIsEmpty);
            RuleFor(x => x.FavListName).MinimumLength(2).WithMessage(Messages.ListNameMinLength);
            RuleFor(x => x.FavListName).MaximumLength(50).WithMessage(Messages.ListNameMaxLength);
        }
    }
}
