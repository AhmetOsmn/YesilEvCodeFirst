using System;
using YesilEvCodeFirst.DTOs.Supplement;

namespace YesilEvCodeFirst.Validation.Supplement
{
    public class AddSupplementValidator : ValidatorBase<AddSupplementDTO>
    {
        public AddSupplementValidator(AddSupplementDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            ProductNameIsEmptyOrNullValidator();
            ProductNameValidator();
        }

        private void ProductNameValidator()
        {
            if (Model.SupplementName.Length > 100)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 100 karakterden fazla olamaz.");
            }
            else if (Model.SupplementName.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi 2 karakterden az olamaz.");
            }
        }

        private void ProductNameIsEmptyOrNullValidator()
        {
            if (string.IsNullOrEmpty(Model.SupplementName))
            {
                IsValid = false;
                ValidationMessages.Add("Urun adi bos olamaz");
            }
        }
    }
}
