using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Yetki : BaseEntity
    {
        [Key]
        public int YetkiID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string YetkiAdi { get; set; }

        #region Ilisker

        public List<Rol> Roller { get; set; }

        #endregion

    }
}
