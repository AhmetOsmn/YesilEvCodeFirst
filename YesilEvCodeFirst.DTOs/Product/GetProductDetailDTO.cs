namespace YesilEvCodeFirst.DTOs.Product
{
    public class GetProductDetailDTO
    {
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string CategoryName { get; set; }
        public string Content { get; set; }
        public string FrontPicture { get; set; }
        public string BackPicture { get; set; }
    }
}
