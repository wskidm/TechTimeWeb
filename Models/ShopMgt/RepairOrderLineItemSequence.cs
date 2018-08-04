using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderLineItemSequence
    {
        public int RepairOrderId { get; set; }
        public int LineItemId { get; set; }
        public int Sequence { get; set; }
        public byte[] Timestamp { get; set; }
        public int RepairOrderLineItemSequenceId { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public RepairOrder RepairOrder { get; set; }
    }
}
