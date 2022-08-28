namespace YesilEvCodeFirst.DTOs.UserAdmin
{
    public class AddUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        //todo rolID burada olacak mi?
        public int RolID { get; set; } = 3;
    }
}
