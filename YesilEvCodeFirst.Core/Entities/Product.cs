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
        public string PictureFronthPath { get; set; }
        public string PictureBackPath { get; set; }
        public string ProductContent { get; set; }

        #region Relations
       
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
