using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Role : BaseEntity
    {
        [Key]
        public int RolID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(30)]
        public string RolName { get; set; }
        public int UstRolID { get; set; }
        [ForeignKey("UstRolID")]
        public Role UstRol { get; set; }
    }
}
