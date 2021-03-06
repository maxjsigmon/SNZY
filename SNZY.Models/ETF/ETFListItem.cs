﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNZY.Models.ETF
{
    public class ETFListItem
    {
        public int ETFId { get; set; }
        public string Name { get; set; }
        public string Ticker { get; set; }
        public List<ETF_StockListItem> Holdings { get; set; } = new List<ETF_StockListItem>();
    }
}
