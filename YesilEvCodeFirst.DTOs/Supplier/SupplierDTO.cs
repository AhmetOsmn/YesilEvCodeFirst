namespace YesilEvCodeFirst.DTOs.Supplier
{
    public class SupplierDTO
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public override string ToString()
        {
            return SupplierName;
        }
    }
}
