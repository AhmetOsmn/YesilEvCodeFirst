using System;

namespace YesilEvCodeFirst.DTOs.SearchHistory
{
    public class SearchHistoryDTO
    {
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public DateTime SearchDate { get; set; }
    }
}
