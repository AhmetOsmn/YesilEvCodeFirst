using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Rol
{
    public class RolDetayDTO
    {
        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public List<int> Yetkiler { get; set; }
    }
}
