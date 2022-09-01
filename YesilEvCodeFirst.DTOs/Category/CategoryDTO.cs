namespace YesilEvCodeFirst.DTOs.Category
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
