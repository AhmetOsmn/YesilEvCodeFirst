using System;
using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Urun
{
    public class UrunEkleDTO
    {
        public string UrunAdi { get; set; }
        //todo guid yerine string mi olacak?
        public Guid BarkodNo { get; set; }
        public string Aciklama { get; set; }
        public string FrontPicture { get; set; }
        public string BackPicture { get; set; }
        public int KategoriID { get; set; }
        public int UreticiID { get; set; }
        public int MarkaID { get; set; }
        public List<YesilEvCodeFirst.Core.Entities.Madde> Maddeler { get; set; }
    }
}
