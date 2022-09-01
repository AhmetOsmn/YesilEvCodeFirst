using System.ComponentModel.DataAnnotations;

namespace YesilEvCodeFirst.Core.Entities
{
    public class SearchHistory : BaseEntity
    {
        [Key]
        public int SearchHistoryId { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
