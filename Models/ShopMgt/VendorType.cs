using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VendorType
    {
        public VendorType()
        {
            Vendor = new HashSet<Vendor>();
        }

        public int VendorTypeId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Vendor> Vendor { get; set; }
    }
}
