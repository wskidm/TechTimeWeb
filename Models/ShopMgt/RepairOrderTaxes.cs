using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderTaxes
    {
        public int RepairOrderId { get; set; }
        public int TaxId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
        public Tax Tax { get; set; }
    }
}
