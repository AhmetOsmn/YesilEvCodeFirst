using System;

namespace YesilEvCodeFirst.Core.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate{ get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public int CreatedBy{ get; set; }
        public int ModifiedBy{ get; set; }
    }
}
