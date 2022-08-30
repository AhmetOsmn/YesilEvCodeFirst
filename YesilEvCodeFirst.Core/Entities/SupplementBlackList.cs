using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class SupplementBlackList
    {
        [Key, Column(Order = 0)]
        public int SupplementID { get; set; }
        public virtual Supplement Supplement { get; set; }

        [Key, Column(Order = 1)]
        public int BlackListID { get; set; }
        public virtual BlackList BlackList { get; set; }
    }
}
