using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.User
{
    public class AddUserValidator : ValidatorBase<AddUserDTO>
    {
        public AddUserValidator(AddUserDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            FirstNameValidator();
            LastNameValidator();
            EmailValidator();
            PasswordValidator();
            PhoneValidator();
        }
        private void FirstNameValidator()
        {
            if (Model.FirstName.Length <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Ad alanı boş bırakılamaz.");
            }
        }

        private void LastNameValidator()
        {
            if (Model.LastName.Length <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Soyad alanı boş bırakalımaz.");
            }
        }
        private void EmailValidator()
        {
            if (Model.Email.Length <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Email alanı boş bırakalımaz.");
            }
        }
        private void PasswordValidator()
        {
            if (Model.Password.Length <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Şifre alanı boş bırakalımaz.");
            }
        }
        private void PhoneValidator()
        {
            if (Model.Phone.Length <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Telefon alanı boş bırakalımaz.");
            }
        }
    }
}
