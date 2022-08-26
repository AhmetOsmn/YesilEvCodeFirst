using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Madde : BaseEntity
    {
        [Key]
        public int MaddeID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string MaddeAdi { get; set; }

        #region Iliskiler

        public List<Kullanici> Kullanicilar { get; set; }

        public List<Urun> Urunler { get; set; }

        #endregion
    }
}
