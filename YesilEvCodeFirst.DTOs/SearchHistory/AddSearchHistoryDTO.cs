using System;

namespace YesilEvCodeFirst.DTOs.SearchHistory
{
    public class AddSearchHistoryDTO
    {
        public int UserID { get; set; }
        public int ProductID{ get; set; }
        public DateTime SearchTime { get; set; } = DateTime.Now;
    }
}
