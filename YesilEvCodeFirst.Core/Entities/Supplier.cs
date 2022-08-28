using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Supplier : BaseEntity
    {
        [Key]
        public int SupplierID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string SupplierName { get; set; }
    }
}
