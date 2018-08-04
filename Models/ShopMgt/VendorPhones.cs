using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VendorPhones
    {
        public int VendorId { get; set; }
        public int PhoneId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public PhoneNum Phone { get; set; }
        public Vendor Vendor { get; set; }
    }
}
