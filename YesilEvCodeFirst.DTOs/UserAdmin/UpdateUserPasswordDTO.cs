using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.UserAdmin
{
    public class UpdateUserPasswordDTO
    {
        public int UserID { get; set; }
        public string NewPassword { get; set; }
    }
}
