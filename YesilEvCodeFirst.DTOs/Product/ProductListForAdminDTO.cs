using System;

namespace YesilEvCodeFirst.DTOs.Product
{
    public class ProductListForAdminDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string TracingNo { get; set; }
        public bool IsApproved { get; set; } = false;
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
        public string PictureContentPath { get; set; }
        public string ProductContent { get; set; }
        public string SupplierName { get; set; }
        public string AdderName { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ApproverName { get; set; }
    }
}
