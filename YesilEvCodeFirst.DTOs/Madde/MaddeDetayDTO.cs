using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Madde
{
    public class MaddeDetayDTO
    {
        public string MaddeAdi { get; set; }
        //todo: burada string olarak kullanici adini mi alacagiz, yoksa int olarak KullaniciID'mi almaliyiz
        public List<int> Kullanicilar { get; set; }
        public List<int> Urunler { get; set; }
    }
}
