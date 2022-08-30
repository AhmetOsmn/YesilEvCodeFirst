using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class ProductSupplement
    {
        [Key, Column(Order = 0)]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Key, Column(Order = 1)]
        public int SupplementID { get; set; }
        public virtual Supplement Supplement { get; set; }
    }
}
