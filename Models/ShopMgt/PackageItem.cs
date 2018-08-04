using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PackageItem
    {
        public PackageItem()
        {
            PackageLineSequence = new HashSet<PackageLineSequence>();
        }

        public int PackageItemId { get; set; }
        public int LineItemId { get; set; }
        public bool TaxAsPart { get; set; }
        public string PackageCode { get; set; }
        public int? PackageId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public Package Package { get; set; }
        public ICollection<PackageLineSequence> PackageLineSequence { get; set; }
    }
}
