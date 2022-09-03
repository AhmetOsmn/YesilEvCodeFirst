using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.Login
{
    public class LoginValidator : ValidatorBase<LoginDTO>
    {
        public LoginValidator(LoginDTO model) : base(model)
        {
        }

        public override void OnValidate()
        {
            EmailValidator();
            PasswordValidator();
        }
        private void EmailValidator()
        {
            //todo: email olup olmadigi kontrolleri eklenecek. @ var mi, .com vb. bir uzantisi var mi. 
            if (string.IsNullOrEmpty(Model.Email))
            {
                IsValid = false;
                ValidationMessages.Add("Email boş bırakılamaz.");
            }  
            else if (Model.Email.Length > 50)
            {
                IsValid = false;
                ValidationMessages.Add("Email 50 karakterden fazla olamaz.");
            }
        }

        private void PasswordValidator()
        {
            if (string.IsNullOrEmpty(Model.Password))
            {
                IsValid = false;
                ValidationMessages.Add("Şifre boş bırakalımaz.");
            }
            else if (Model.Password.Length > 25)
            {
                IsValid = false;
                ValidationMessages.Add("Şifre 25 karakterden fazla olamaz.");
            }
        }
    }
}
