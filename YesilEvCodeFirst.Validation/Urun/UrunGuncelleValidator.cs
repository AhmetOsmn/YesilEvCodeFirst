using System.Linq;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Validation.Urun
{
    public class UrunGuncelleValidator : ValidatorBase<UrunGuncelleDTO>
    {
        public UrunGuncelleValidator(UrunGuncelleDTO model) : base(model)
        {
        }
        // todo: UrunEkle validator ile cok ortak validasyonlar var. Kod tekrari nasıl engellenebilir?
        // extension sinif mi hazirlamamiz gerekir?
        public override void OnValidate()
        {
            UrunAdiBosMuValidator();
            UrunAdiUzunlukValidator();
            UrunAciklamaUzunlukValidator();
            UrunBarkodNoValidator();
            UrunKategoriIDValidator();
            UrunUreticiIDValidator();
            UrunMarkaIDValidator();
            UrunMaddelerValidator();
        }

        private void UrunMaddelerValidator()
        {
            // maddeler'listesinde 0 veya negatif bir ID olmasini istemiyoruz.
            if(Model.Maddeler.Any(id => id <= 0))
            {
                IsValid = false;
                ValidationMessages.Add("Lutfen 0 dan kücük ID veya ID'ler girmeyiniz.");
            }
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
            if (Model.UrunAdi.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 100 karakterden fazla olamaz.");
            }
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
            if (string.IsNullOrEmpty(Model.UrunAdi))
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
