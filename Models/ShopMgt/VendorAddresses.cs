using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VendorAddresses
    {
        public int VendorId { get; set; }
        public int AddressId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Addresses Address { get; set; }
        public Vendor Vendor { get; set; }
    }
}
