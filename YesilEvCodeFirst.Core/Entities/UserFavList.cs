using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class UserFavList
    {
        [Key, Column(Order = 0)]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }


        [Key, Column(Order = 1)]
        public int FavListID { get; set; }
        [ForeignKey("FavListID")]
        public virtual FavList FavList { get; set; }
    }
}
