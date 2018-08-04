using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VendorLink
    {
        public int VendorId { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Vendor Vendor { get; set; }
    }
}
