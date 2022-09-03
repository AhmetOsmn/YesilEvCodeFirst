using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    
    public enum Risk {
        Temiz = 0,
        AzRiskli = 1,
        OrtaRiskli = 2,
        Riskli = 3,
    }

    public class Supplement : BaseEntity
    {
        [Key]
        public int SupplementID { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string SupplementName { get; set; }
        public Risk RiskRatio { get; set; }
        public List<ProductSupplement> ProductSupplements { get; set; }
        public List<SupplementBlackList> SupplementBlackLists { get; set; }
    }
}
