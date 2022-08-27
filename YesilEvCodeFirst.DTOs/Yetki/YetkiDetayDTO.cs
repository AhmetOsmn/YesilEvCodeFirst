using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Yetki
{
    public class YetkiDetayDTO
    {
        public int YetkiID { get; set; }
        public string YetkiAdi { get; set; }
        public List<int> Roller { get; set; }
    }
}
