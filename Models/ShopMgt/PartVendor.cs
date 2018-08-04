using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartVendor
    {
        public int PartId { get; set; }
        public int VendorId { get; set; }
        public int Priority { get; set; }
        public byte[] Timestamp { get; set; }
        public int PartVendorId { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public Vendor Vendor { get; set; }
    }
}
