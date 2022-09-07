using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.UserAdmin
{
    public class UserForAdminDTO
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int RolID { get; set; }
    }
}
