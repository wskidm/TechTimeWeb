using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderStatus
    {
        public int RepairOrderStatusId { get; set; }
        public string StatusDescription { get; set; }
        public bool Flagged { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
