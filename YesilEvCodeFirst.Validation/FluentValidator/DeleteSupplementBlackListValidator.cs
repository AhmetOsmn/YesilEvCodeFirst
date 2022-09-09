using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.SupplementBlackList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class DeleteSupplementBlackListValidator : AbstractValidator<DeleteSupplementBlackListDTO>
    {
        public DeleteSupplementBlackListValidator()
        {
            #region BlakcListID Validation Black List Page
            //BlakcListID validation for Black List Page
            RuleFor(x => x.BlackListID).GreaterThan(0).WithMessage("Kara liste ID sıfırdan küçük olamaz.");
            #endregion

            #region SupplementID Validation Black List Page
            //SupplementContext validation for Black List Page
            RuleFor(x => x.SupplementID).GreaterThan(0).WithMessage(ValidationMessages.SupplementIDIsEmpty);
            #endregion

            #region UserID Validation Black List Page
            //UserID validation for Black List Page
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage("Kullanıcı ID sıfırdan küçük olamaz.");
            #endregion
        }

    }
}
