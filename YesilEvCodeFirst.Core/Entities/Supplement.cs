using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    //todo: risk orani eklenecek
    public class Supplement : BaseEntity
    {
        [Key]
        public int SupplementID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string SupplementName { get; set; }
        public List<Product> Products { get; set; }
        public List<BlackList> BlackLists { get; set; }
    }
}
