using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Urun
{
    public class UrunListeleDTO
    {
        public string UrunAdi { get; set; }
        //todo guid yerine string mi olacak?
        public string BarkodNo { get; set; }
        public string Aciklama { get; set; }
        // Alt kisimdaki alanlari detayDTO ile gorebiliriz.
        //Listeleme islemi icin ustteki 3 alan yeterli bence.

        //List<string> Pictures { get; set; }
        //public int KategoriID { get; set; }
        //public int UreticiID { get; set; }
        //public int MarkaID { get; set; }
        //public List<int> Maddeler { get; set; }

    }
}
