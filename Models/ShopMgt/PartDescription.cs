using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartDescription
    {
        public int PartDescriptionId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? VendorId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
        public Vendor Vendor { get; set; }
    }
}
