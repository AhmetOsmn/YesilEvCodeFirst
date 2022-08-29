using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.UserAdmin
{
    public class GetUserDetailDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreatedDate { get; set; }
        // bu kisim burada olmayabilir
        //public int EkledigiUrunSayisi { get; set; }
    }
}
