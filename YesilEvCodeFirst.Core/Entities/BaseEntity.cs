using System;

namespace YesilEvCodeFirst.Core.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate{ get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "Machine";
    }
}
