using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class DeleteFavListValidator : AbstractValidator<EditFavListDTO>
    {
        public DeleteFavListValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(Messages.InvalidID);
            RuleFor(x => x.FavorID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
