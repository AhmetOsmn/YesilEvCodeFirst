using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.ProductFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class FavListProductDTOValidator : AbstractValidator<FavListProductDTO>
    {
        public FavListProductDTOValidator()
        {
            RuleFor(x => x.ProductID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
            RuleFor(x => x.FavListID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
        }
    }
}
