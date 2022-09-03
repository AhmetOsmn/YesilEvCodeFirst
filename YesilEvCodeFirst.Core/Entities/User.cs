using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class User : BaseEntity
    {
        [Key]
        public int UserID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(25)]
        public string Phone { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(10)]
        public string Password { get; set; }

        public int RolID { get; set; }
        [ForeignKey("RolID")]
        public Role Rol { get; set; }
        public List<Product> Products { get; set; }
        public List<SearchHistory> UserSearchHistories { get; set; }
    }
}
