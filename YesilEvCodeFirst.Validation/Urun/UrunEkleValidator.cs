using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Validation.Urun
{
    public class UrunEkleValidator : ValidatorBase<UrunEkleDTO>
    {
        public UrunEkleValidator(UrunEkleDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            UrunAdiBosMuValidator();
            UrunAdiUzunlukValidator();
            UrunAciklamaUzunlukValidator();
            UrunBarkodNoValidator();
            UrunKategoriIDValidator();
            UrunUreticiIDValidator();
            UrunMarkaIDValidator();
        }

        private void UrunMarkaIDValidator()
        {
            if (Model.MarkaID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void UrunUreticiIDValidator()
        {
            if (Model.UreticiID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void UrunKategoriIDValidator()
        {
            if (Model.KategoriID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void UrunAdiUzunlukValidator()
        {
            if(Model.UrunAdi.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 100 karakterden fazla olamaz.");
            }
            // todo
            // bu kontrolu ilk defa burada yazdim. bu kontrol icin sinifin icerisine de attribute eklenmeli mi?
            // sinif icerisinde Aciklama prop'unun ust satirinda max uzunlugu 100 olarak belirtmistim ama min uzunlugu belirtmedim.
            else if (Model.UrunAdi.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 2 karakterden az olamaz.");
            }
        }

        private void UrunAciklamaUzunlukValidator()
        {
            if (Model.Aciklama.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun aciklamasi 100 karakterden fazla olamaz.");
            }
            else if (Model.Aciklama.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Urun aciklamasi 2 karakterden az olamaz.");
            }
        }

        private void UrunAdiBosMuValidator()
        {
            if(string.IsNullOrEmpty(Model.UrunAdi))
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi bos olamaz");
            }
        }

        private void UrunBarkodNoValidator()
        {
            if (Model.BarkodNo == null)
            {
                IsValid = false;
                ValidationMessages.Add("BarkodNo bos olamaz.");
            }
        }
    }
}
