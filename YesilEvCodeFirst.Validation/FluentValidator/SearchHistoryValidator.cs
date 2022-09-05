using FluentValidation;
using YesilEvCodeFirst.DTOs.SearchHistory;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class SearchHistoryValidator : AbstractValidator<AddSearchHistoryDTO>
    {
        public SearchHistoryValidator()
        {
            #region UserID Validation Search History Page
            //UserID validation for Search History Page
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage("Kullanıcı ID sıfırdan küçük olamaz.");
            #endregion

            #region ProductID Validation Search History Page
            //ProductID validation for Search History Page
            RuleFor(x => x.ProductID).GreaterThan(0).WithMessage("Ürün ID sıfırdan küçük olamaz.");
            #endregion
        }
    }
}
