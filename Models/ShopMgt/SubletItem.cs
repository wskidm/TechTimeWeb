using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SubletItem
    {
        public int SubletItemId { get; set; }
        public int LineItemId { get; set; }
        public int? VendorId { get; set; }
        public string WorkPerformed { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public Vendor Vendor { get; set; }
    }
}
