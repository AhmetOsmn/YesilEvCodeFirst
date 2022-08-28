using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Picture : BaseEntity
    {
        [Key]
        public int PictureID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string PictureName { get; set; }
        public string PicturePath { get; set; }
    }
}
