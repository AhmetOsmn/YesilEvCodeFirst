using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class ProductFavList : BaseEntity
    {
        [Key, Column(Order = 0)]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Key, Column(Order = 1)]
        public int FavListID { get; set; }
        public virtual FavList FavList { get; set; }
    }
}
