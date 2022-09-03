using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.ProductFavList
{
    public class AddProductFavListDTO
    {
        public int ProductID { get; set; }
        public int FavorID { get; set; }
        public int UserID { get; set; }
    }
}
