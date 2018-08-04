using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RecordNumber
    {
        public int RecordNumberId { get; set; }
        public int RepairOrderId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
    }
}
