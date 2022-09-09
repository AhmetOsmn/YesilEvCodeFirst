namespace YesilEvCodeFirst.Common
{
    public static class ValidationMessages
    {
        public static string InvalidID = "Girilen ID 0'dan büyük olmalı.";

        public static string SupplierIDNull = "Üretici alanı boş geçilemez.";
        public static string CategoryIDNull = "Kategori alanı boş geçilemez.";

        public static string PasswordIsEmpty = "Şifre alanı boş geçilemez.";
        public static string PasswordsNotEqual = "Girilen şifreler eşleşmiyor.";
        public static string PasswordMinLength = "Şifre minimum 5 karakter olabilir.";
        public static string PasswordMaxLength = "Şifre maksimum 30 karakter olabilir.";

        public static string InvalidEmail = "Email geçersiz.";
        public static string EmailIsEmpty = "Email alanı boş geçilemez.";
        public static string EmailsNotEqual = "Girilen email'ler eşleşmiyor.";
        public static string EmailMinLength = "Email alanı 5 karakterden küçük olamaz.";
        public static string EmailMaxLength = "Email alanı 50 karakterden büyük olamaz.";


        public static string FirstNameIsEmpty = "Kullanıcı adı boş olamaz.";
        public static string FirstNameMinLength = "Kullanıcı adı minimum 2 karakter olabilir.";
        public static string FirstNameMaxLength = "Kullanıcı adı maksimum 100 karakter olabilir.";

        public static string LastNameIsEmpty = "Kullanıcı soyadı boş olamaz.";
        public static string LastNameMinLength = "Kullanıcı soyadı minimum 2 karakter olabilir.";
        public static string LastNameMaxLength = "Kullanıcı soyadı maksimum 100 karakter olabilir.";

        public static string PhoneIsEmpty = "Telefon numarası alanı boş olamaz.";
        public static string PhoneMinLength = "Telefon numarası minimum 10 karakter olabilir.";
        public static string PhoneMaxLength = "Telefon numarası maksimum 25 karakter olabilir.";

        public static string ListNameIsEmpty = "Liste adı boş geçilemez.";
        public static string ListNameMinLength = "Liste adı minimum 2 karakter olabilir.";
        public static string ListNameMaxLength = "Liste adı maksimum 50 karakter olabilir.";

        public static string ProductNameIsEmpty = "Ürün adı boş geçilemez";
        public static string BarcodeIsEmpty = "Barkod alanı boş geçilemez";
        public static string SupplementIDIsEmpty = "SupplementID alanı boş olamaz";
        public static string ProductNameMinLength = "Ürün adı minimum 2 karakter olabilir.";
        public static string ProductContentIsEmpty = "Ürün içerik alanı boş geçilemez.";
        public static string ProductNameMaxLength = "Ürün adı maksimum 100 karakter olabilir.";
        public static string BarcodeMinLength = "Barkod numarası minimum 7 karakter olabilir.";
        public static string BarcodeMaxLength = "Barkod numarası maksimum 50 karakter olabilir.";

        public static string SupplierNameEmpty = "Üretici adı boş geçilemez.";
        public static string SupplierNameMinLength = "Üretici adı minimum 2 karakter olabilir.";
        public static string SupplierNameMaxLength = "Üretici adı maksimum 100 karakter olabilir.";
    }
}
