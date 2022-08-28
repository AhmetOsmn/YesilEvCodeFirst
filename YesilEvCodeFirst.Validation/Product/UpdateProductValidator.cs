using System.Linq;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.Urun
{
    public class UpdateProductValidator : ValidatorBase<UpdateProductDTO>
    {
        public UpdateProductValidator(UpdateProductDTO model) : base(model)
        {
        }
        // todo: UrunEkle validator ile cok ortak validasyonlar var. Kod tekrari nasıl engellenebilir?
        // extension sinif mi hazirlamamiz gerekir?
        public override void OnValidate()
        {
            ProductNameIsEmptyOrNullValidator();
            ProductNameValidator();
            ProductContentValidator();
            BarcodeCodeValidator();
            CategoryIDValidator();
            SupplierIDValidator();
        }

        private void SupplierIDValidator()
        {
            if (Model.SupplierID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void CategoryIDValidator()
        {
            if (Model.CategoryID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void ProductNameValidator()
        {
            if (Model.ProductName.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 100 karakterden fazla olamaz.");
            }
            else if (Model.ProductName.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 2 karakterden az olamaz.");
            }
        }

        private void ProductContentValidator()
        {
            if (Model.ProductContent.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun aciklamasi 100 karakterden fazla olamaz.");
            }
            else if (Model.ProductContent.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Urun aciklamasi 2 karakterden az olamaz.");
            }
        }

        private void ProductNameIsEmptyOrNullValidator()
        {
            if (string.IsNullOrEmpty(Model.ProductName))
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi bos olamaz");
            }
        }

        private void BarcodeCodeValidator()
        {
            if (Model.Barcode == null)
            {
                IsValid = false;
                ValidationMessages.Add("BarkodNo bos olamaz.");
            }
        }
    }
}
