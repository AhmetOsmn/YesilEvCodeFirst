using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class FavList
    {
        [Key]
        public int FavorID { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User{ get; set; }
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public List<Product> Products { get; set; }
    }
}
