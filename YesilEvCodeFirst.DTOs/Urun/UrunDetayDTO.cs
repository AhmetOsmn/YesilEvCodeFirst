using System;
using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Urun
{
    public class UrunDetayDTO
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string BarkodNo { get; set; } 
        public string Aciklama { get; set; }
        List<string> Pictures { get; set; }
        public int KategoriID { get; set; }
        public int UreticiID { get; set; }
        public int MarkaID { get; set; }
        public List<int> Maddeler { get; set; }
    }
}
