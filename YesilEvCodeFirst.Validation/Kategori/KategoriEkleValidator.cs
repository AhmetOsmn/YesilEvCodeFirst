using System;
using YesilEvCodeFirst.DTOs.Kategori;

namespace YesilEvCodeFirst.Validation.Kategori
{
    public class KategoriEkleValidator : ValidatorBase<KategoriEkleDTO>
    {
        public KategoriEkleValidator(KategoriEkleDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            KategoriAdiBosMuValidator();
            KategoriAdiUzunlukValidator();
            KategoriUstKategoriIDValidator();
        }

        private void KategoriUstKategoriIDValidator()
        {
            if(Model.UstKategoriID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0 dan buyuk bir ID giriniz.");
            }
        }

        private void KategoriAdiUzunlukValidator()
        {
            throw new NotImplementedException();
        }

        private void KategoriAdiBosMuValidator()
        {
            throw new NotImplementedException();
        }
    }
}
