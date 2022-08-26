using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Marka : BaseEntity
    {
        [Key]
        public int MarkaID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string MarkaAdi { get; set; }
    }
}
