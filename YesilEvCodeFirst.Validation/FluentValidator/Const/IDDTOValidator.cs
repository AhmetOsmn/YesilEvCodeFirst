using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class IDDTOValidator : AbstractValidator<IDDTO>
    {
        public IDDTOValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);
        }
    }
}
