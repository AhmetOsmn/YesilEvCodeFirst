namespace YesilEvCodeFirst.Common
{
    public static class Messages
    {
        #region Validation

        public static string InvalidID = "Girilen ID 0'dan büyük olmalı.";
       
        public static string ListNameMaxLength = "Liste adı maksimum 50 karakter olabilir.";
        public static string ListNameMinLength = "Liste adı minimum 2 karakter olabilir.";
        public static string ListNameIsEmpty = "Liste adı boş geçilemez";

        public static string ProductNameIsEmpty = "Ürün adı boş geçilemez";
        public static string ProductNameMaxLength = "Ürün adı maksimum 100 karakter olabilir.";
        public static string ProductNameMinLength = "Ürün adı minimum 2 karakter olabilir.";
        public static string BarcodeIsEmpty = "Barkod alanı boş geçilemez";
        public static string BarcodeMaxLength = "Barkod numarası maksimum 50 karakter olabilir.";
        public static string BarcodeMinLength = "Barkod numarası minimum 7 karakter olabilir.";
        public static string ProductContentIsEmpty = "Ürün içerik alanı boş geçilemez.";
        public static string CategoryNameIsEmpty = "Kategori alanı boş geçilemez."; 


        #endregion


        #region Exception

        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string AdminNotFound = "Admin bulunamadı.";

        public static string BlackListAlreadyExist = "Kara liste zaten mevcut.";
        public static string BlackListNotFound = "Kara liste bulunamadı";

        public static string FavListAlreadyExist = "Favori listesi zaten mevcut.";
        public static string FavListNotFound = "Favori listesi bulunamadı";

        public static string CategoryNotFound = "Kategori bulunamadi.";

        public static string ProductAlreadyExist = "Ürün zaten mevcut.";
        public static string ProductNotFound = "Ürün bulunamadı.";
        public static string DoesNotBelongUser = "Ürün kullanıcıya ait değil.";
        public static string ProductListIsEmpty = "Ürün Listesi boş.";


        #endregion

    }
}
