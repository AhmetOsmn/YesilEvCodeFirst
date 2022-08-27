using System;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Validation.Urun
{
    public class UrunDetayGetirValidator : ValidatorBase<UrunDetayGetirDTO>
    {
        public UrunDetayGetirValidator(UrunDetayGetirDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            UrunDetayIDValidator();
        }

        private void UrunDetayIDValidator()
        {
            if(Model.UrunID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lutfen 0'dan buyuk ID giriniz.");
            }
        }
    }
}
