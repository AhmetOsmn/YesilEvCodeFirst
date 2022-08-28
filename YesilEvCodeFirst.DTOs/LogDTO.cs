using System;

namespace YesilEvCodeFirst.DTOs
{
    public enum Islem
    {
        Warning = 0,
        Error = 5,
        Info = 10,
        Success = 15
    }

    public class LogDTO
    {
        public string Tablo { get; set; }
        public string Kisi { get; set; }
        public Islem Islem { get; set; }
        public string DataID { get; set; }
        public string Not { get; set; }
        public string IslemTarihi { get; set; }
    }
}
