using System.Collections.Generic;

namespace YesilEvCodeFirst.DTOs.Rol
{
    public class RolEkleDTO
    {
        public string RolAdi { get; set; }
        public List<int> Yetkiler { get; set; }
    }
}
