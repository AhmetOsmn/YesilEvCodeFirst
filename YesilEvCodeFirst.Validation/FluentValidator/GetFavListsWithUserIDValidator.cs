using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetFavListsWithUserIDValidator : AbstractValidator<IDDTO>
    {
        public GetFavListsWithUserIDValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
