using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Barcode { get; set; }
        public string TracingNo { get; set; } = Guid.NewGuid().ToString();
        public bool IsApproved { get; set; } = false;
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
        public string PictureContent { get; set; }
        public string ProductContent { get; set; }

        #region Relations

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        public int AddedBy { get; set; }
        [ForeignKey("AddedBy")]
        public User Adder { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public int? ApprovedBy { get; set; }
        [ForeignKey("ApprovedBy")]
        public User Admin { get; set; } 

        public List<ProductSupplement> ProductSupplements{ get; set; }
        public List<ProductFavList> ProductFavList { get; set; }
        public List<SearchHistory> ProductSearchHistories { get; set; }

        #endregion
    }
}
