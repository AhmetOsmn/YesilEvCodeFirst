using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Kategori : BaseEntity
    {
        [Key]
        public int KategoriID { get; set; }


        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string KategoriAdi { get; set; }

        #region Iliskiler

        public int UstKategoriID { get; set; }

        [ForeignKey("UstKategoriID")]
        public Kategori UstKategori { get; set; }

        #endregion
    }
}
