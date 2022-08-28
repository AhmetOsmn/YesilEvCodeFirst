using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public int? UstCategoryID { get; set; }
        [ForeignKey("UstCategoryID")]
        public Category UstCategory { get; set; }
    }
}
