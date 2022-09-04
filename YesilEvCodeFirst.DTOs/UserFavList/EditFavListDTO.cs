using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.UserFavList
{
    public class EditFavListDTO
    {
        public int UserID { get; set; }
        public int FavorID { get; set; }
        public string FavoriListName { get; set; }
    }
}
