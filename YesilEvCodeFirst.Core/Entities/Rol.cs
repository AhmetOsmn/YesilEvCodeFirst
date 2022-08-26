using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Rol : BaseEntity
    {
        [Key]
        public int RolID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string RolAdi { get; set; }

        #region Iliskiler

        public List<Yetki> Yetkiler { get; set; }

        #endregion
    }
}
