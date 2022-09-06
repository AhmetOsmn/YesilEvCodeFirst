namespace YesilEvCodeFirst.Common
{
    public static class Messages
    {
        #region Validation

        public static string InvalidID = "Girilen ID 0'dan büyük olmalı.";

        public static string CategoryIDNull = "Kategori alanı boş geçilemez.";
        public static string SupplierIDNull = "Üretici alanı boş geçilemez.";

        public static string PasswordIsEmpty = "Şifre alanı boş geçilemez.";
        public static string PasswordMinLength = "Şifre minimum 5 karakter olabilir.";
        public static string PasswordMaxLength = "Şifre maksimum 30 karakter olabilir.";

        public static string EmailIsEmpty = "Email alanı boş geçilemez.";
        public static string InvalidEmail = "Email geçersiz.";
        public static string EmailMinLength = "Email alanı 5 karakterden küçük olamaz.";
        public static string EmailMaxLength = "Email alanı 50 karakterden büyük olamaz.";

        public static string FirstNameIsEmpty = "Kullanıcı adı boş olamaz.";
        public static string FirstNameMaxLength = "Kullanıcı adı maksimum 100 karakter olabilir.";
        public static string FirstNameMinLength = "Kullanıcı adı minimum 2 karakter olabilir.";

        public static string LastNameIsEmpty = "Kullanıcı soyadı boş olamaz.";
        public static string LastNameMaxLength = "Kullanıcı soyadı maksimum 100 karakter olabilir.";
        public static string LastNameMinLength = "Kullanıcı soyadı minimum 2 karakter olabilir.";

        public static string PhoneIsEmpty = "Telefon numarası alanı boş olamaz.";
        public static string PhoneMaxLength = "Telefon numarası maksimum 25 karakter olabilir.";
        public static string PhoneMinLength = "Telefon numarası minimum 10 karakter olabilir."; 

        public static string ListNameMaxLength = "Liste adı maksimum 50 karakter olabilir.";
        public static string ListNameMinLength = "Liste adı minimum 2 karakter olabilir.";
        public static string ListNameIsEmpty = "Liste adı boş geçilemez.";

        public static string ProductNameIsEmpty = "Ürün adı boş geçilemez";
        public static string ProductNameMaxLength = "Ürün adı maksimum 100 karakter olabilir.";
        public static string ProductNameMinLength = "Ürün adı minimum 2 karakter olabilir.";
        public static string BarcodeIsEmpty = "Barkod alanı boş geçilemez";
        public static string BarcodeMaxLength = "Barkod numarası maksimum 50 karakter olabilir.";
        public static string BarcodeMinLength = "Barkod numarası minimum 7 karakter olabilir.";
        public static string ProductContentIsEmpty = "Ürün içerik alanı boş geçilemez.";
        public static string SupplementIDIsEmpty = "SupplementID alanı boş olamaz";



        #endregion


        #region Exception

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string EmailAlreadyExist = "Email zaten kayıtlı.";

        public static string AdminNotFound = "Admin bulunamadı.";

        public static string BlackListAlreadyExist = "Kara liste zaten mevcut.";
        public static string BlackListNotFound = "Kara liste bulunamadı.";

        public static string FavListAlreadyExist = "Favori listesi zaten mevcut.";
        public static string FavListNotFound = "Favori listesi bulunamadı";

        public static string CategoryNotFound = "Kategori bulunamadi.";
        public static string SearchHistoryNotFoundForList = "Listelenecek arama geçmişi bulunamadi.";

        public static string ProductAlreadyExist = "Ürün zaten mevcut.";
        public static string ProductNotFound = "Ürün bulunamadı.";
        public static string ProductNotFoundForList = "Listelenecek ürün bulunamadı.";
        public static string SupplementNotFoundForList = "Listelenecek madde bulunamadı.";

        public static string SupplierNotFoundForList = "Listelenecek üretici bulunamadı.";
        public static string DoesNotBelongUser = "Ürün kullanıcıya ait değil.";
        public static string ProductListIsEmpty = "Ürün Listesi boş.";

        public static string ProductAlreadyExistInList = "Listeden bulunan ürün tekrar listeye eklenemez.";

        public static string SupplementAlreadyExist = "Madde zaten mevcut.";

        #endregion

    }
}
