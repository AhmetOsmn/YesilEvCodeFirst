using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateFavListValidator : AbstractValidator<EditFavListDTO>
    {
        public UpdateFavListValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
            RuleFor(x => x.FavorID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
        }
    }
}
