using System;

namespace YesilEvCodeFirst.DTOs.Product
{
    public class UpdateProductDTO
    {
        public string ProductName { get; set; }
        public string BarcodeCode { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public string ProductContent { get; set; }
    }
}
