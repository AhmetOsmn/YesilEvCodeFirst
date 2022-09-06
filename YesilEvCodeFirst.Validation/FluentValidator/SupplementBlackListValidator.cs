using FluentValidation;
using YesilEvCodeFirst.DTOs.SupplementBlackList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class SupplementBlackListValidator : AbstractValidator<AddSupplementBlackListDTO>
    {
        public SupplementBlackListValidator()
        {
            #region BlakcListID Validation Black List Page
            //BlakcListID validation for Black List Page
            RuleFor(x => x.BlackListID).GreaterThan(0).WithMessage("Kara liste ID sıfırdan küçük olamaz.");
            #endregion

            #region SupplementID Validation Black List Page
            //SupplementContext validation for Black List Page
            RuleFor(x => x.SupplementContext).NotEmpty().WithMessage("Kara Listeye eklenecek madde içeriği boş olamaz");
            #endregion

            #region UserID Validation Black List Page
            //UserID validation for Black List Page
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage("Kullanıcı ID sıfırdan küçük olamaz.");
            #endregion
        }
    }
}
