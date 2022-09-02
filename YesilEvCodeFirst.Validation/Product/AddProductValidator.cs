using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Validation.Product
{
    public class AddProductValidator : ValidatorBase<AddProductDTO>
    {
        public AddProductValidator(AddProductDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            ProductNameIsEmptyOrNullValidator();
            ProductNameValidator();
            ProductContentValidator();
            BarcodeCodeValidator();
            CategoryIDValidator();
            SupplierIDValidator();
            FrontPicturePathValidator();
            BackPicturePathValidator();
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
            if(Model.ProductName.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 100 karakterden fazla olamaz.");
            }
            // todo
            // bu kontrolu ilk defa burada yazdim. bu kontrol icin sinifin icerisine de attribute eklenmeli mi?
            // sinif icerisinde Aciklama prop'unun ust satirinda max uzunlugu 100 olarak belirtmistim ama min uzunlugu belirtmedim.
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
            if(string.IsNullOrEmpty(Model.ProductName))
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
        private void FrontPicturePathValidator()
        {
            if (string.IsNullOrEmpty(Model.PictureFronthPath))
            {
                IsValid = false;
                ValidationMessages.Add("FrontPicturePath bos olamaz.");
            }
        }
        private void BackPicturePathValidator()
        {
            if (string.IsNullOrEmpty(Model.PictureBackPath))
            {
                IsValid = false;
                ValidationMessages.Add("BackPicturePath bos olamaz.");
            }
        }
    }
}
