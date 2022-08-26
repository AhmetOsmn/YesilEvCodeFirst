using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Kullanici : BaseEntity
    {
        [Key]
        public int KullaniciID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Isim { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Soyisim{ get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Mail { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Sifre { get; set; }

        #region Iliskiler

        public int RolID { get; set; }

        [ForeignKey("RolID")]
        public Rol Rol { get; set; }


        public List<Madde> Maddeler { get; set; }

        #endregion
    }
}
