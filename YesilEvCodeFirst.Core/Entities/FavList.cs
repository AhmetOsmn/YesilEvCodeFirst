using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class FavList : BaseEntity
    {
        [Key]
        public int FavorID { get; set; }

        public int UserID { get; set; }
        public User User{ get; set; }

        public List<ProductFavList> ProductFavList { get; set; }
        public List<UserFavList> UserFavList { get; set; }
    }
}
