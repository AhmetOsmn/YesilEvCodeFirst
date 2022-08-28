namespace YesilEvCodeFirst.DTOs.Product
{
    public class AddProductDTO
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public string ProductContent { get; set; }
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
    }
}
