using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SpecialPackageLineItemSequence
    {
        public int SpecialPackageId { get; set; }
        public int Sequence { get; set; }
        public int LineItemId { get; set; }
        public byte[] Timestamp { get; set; }
        public bool UsePackageQuantity { get; set; }
        public int SpecialPackageLineItemSequenceId { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public SpecialPackage SpecialPackage { get; set; }
    }
}
