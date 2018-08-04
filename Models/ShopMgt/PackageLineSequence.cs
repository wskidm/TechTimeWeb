using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PackageLineSequence
    {
        public int PackageItemId { get; set; }
        public int LineItemId { get; set; }
        public int Sequence { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public PackageItem PackageItem { get; set; }
    }
}
