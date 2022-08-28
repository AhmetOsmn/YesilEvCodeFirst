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
        [StringLength(30)]
        public string Barcode { get; set; }

        public string TracingNo { get; set; }
        public string FrontPicture { get; set; }
        public string BackPicture { get; set; }
        public string ProductContent { get; set; }

        #region Relations
        public int SupplementID { get; set; }
        [ForeignKey("SupplementID")]
        public List<Supplement> Supplements { get; set; }


        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }


        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }


        public List<FavList> FavLists { get; set; }


        //public int PictureID { get; set; }
        //[ForeignKey("PictureID")]
        //public Picture Picture { get; set; }
        #endregion
    }
}
