using System;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Validation.Urun
{
    public class UrunSilValidator : ValidatorBase<UrunSilDTO>
    {
        public UrunSilValidator(UrunSilDTO model) : base(model)
        {
        }

        // todo: Urun silebilmek icin bir ID almamiz gerekecek. Bu ID icin validator nasil yazacagiz?
        public override void OnValidate()
        {
            SilinecekUrunIDValidator();
        }

        private void SilinecekUrunIDValidator()
        {
            if(Model.UrunID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen 0'dan buyuk ID'giriniz.");
            }
        }
    }
}
