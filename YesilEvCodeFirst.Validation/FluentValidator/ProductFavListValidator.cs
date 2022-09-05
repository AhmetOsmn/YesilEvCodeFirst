using FluentValidation;
using YesilEvCodeFirst.DTOs.ProductFavList;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class ProductFavListValidator : AbstractValidator<AddProductFavListDTO>

    {
        public ProductFavListValidator()
        {
            #region UserID Validation Product Favori List Page
            //UserID validation for Product Favori List Page
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage("Kullanıcı ID sıfırdan küçük olamaz.");
            #endregion

            #region ProductID Validation Product Favorite List Page
            //ProductID validation for Product Favorite List Page
            RuleFor(x => x.ProductID).GreaterThan(0).WithMessage("Ürün ID sıfırdan küçük olamaz.");
            #endregion

            #region FavorID Validation Product Favori List Page
            //FavorID validation for Product Favori List Page
            RuleFor(x => x.FavorID).GreaterThan(0).WithMessage("Favori ID sıfırdan küçük olamaz.");
            #endregion

        }
    }
}
