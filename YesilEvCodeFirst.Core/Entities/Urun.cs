using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Urun : BaseEntity
    {
        [Key]
        public int UrunID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string UrunAdi { get; set; }
        public Guid BarkodNo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Aciklama { get; set; }

        List<string> Pictures { get; set; }


        #region Iliskiler

        public int KategoriID { get; set; }

        [ForeignKey("KategoriID")]
        public Kategori Kategori { get; set; }


        public int UreticiID { get; set; }

        [ForeignKey("UreticiID")]
        public Uretici Uretici { get; set; }


        public int MarkaID { get; set; }

        [ForeignKey("MarkaID")]
        public Marka Marka { get; set; }


        public List<Madde> Maddeler{ get; set; }

        #endregion
    }
}
