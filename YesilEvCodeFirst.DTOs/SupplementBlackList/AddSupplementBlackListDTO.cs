﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvCodeFirst.DTOs.SupplementBlackList
{
    public class AddSupplementBlackListDTO
    {
        public int BlackListID { get; set; }
        public string SupplementContext { get; set; }
        public int UserID { get; set; }
    }
}
