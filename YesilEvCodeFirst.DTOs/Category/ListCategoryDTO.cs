using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.Category
{
    public class ListCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string UstCategoryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
