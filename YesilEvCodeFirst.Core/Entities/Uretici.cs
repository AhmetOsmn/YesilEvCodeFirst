using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Uretici : BaseEntity
    {
        [Key]
        public int UreticiID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string UreticiAdi { get; set; }
    }
}
