using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CustomerYtdadjustment
    {
        public int CustomerYtdadjustmentId { get; set; }
        public int CustId { get; set; }
        public decimal Ytdadjustment { get; set; }
        public DateTime DateAdjusted { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
    }
}
