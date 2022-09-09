namespace YesilEvCodeFirst.DTOs.UserAdmin
{
    public class UpdateUserPasswordDTO
    {
        public int UserID { get; set; }
        public string NewPassword { get; set; }
        public string ReNewPassword { get; set; }
    }
}
