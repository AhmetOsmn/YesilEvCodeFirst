using FluentValidation;
using YesilEvCodeFirst.DTOs.Supplement;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class SupplementValidator : AbstractValidator<AddSupplementDTO>
    {
        public SupplementValidator()
        {
            #region AddOrEditProduct Page
            //Supplement validation for AddOrEditProduct Page
            RuleFor(x => x.SupplementName).NotEmpty().WithMessage("Madde ismi alanı boş bırakılamaz.");
            RuleFor(x => x.SupplementName).MaximumLength(100).WithMessage("Madde isim alanı 100 karakterden büyük olamaz.");
            RuleFor(x => x.SupplementName).MinimumLength(2).WithMessage("Madde isim alanı 2 karakterden küçük olamaz.");
            #endregion
        }
    }
}
