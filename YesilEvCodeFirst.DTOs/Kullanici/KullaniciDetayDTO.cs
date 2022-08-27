using System;
using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Kullanici
{
    public class KullaniciDetayDTO
    {
        public int KullaniciID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        public List<int> YasakMaddeler{ get; set; }
        //todo burada fav listesi ve kara liste olacak sanirim
    }
}
