using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.Rapor
{
    public class UserFavoriAndBlacklistProductCountDTO
    {
        public string UserFirstAndLastName { get; set; }
        public int FavoriCount { get; set; }
        public int BlackListCount { get; set; }
    }
}
