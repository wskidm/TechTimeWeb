using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartTaxAssociation
    {
        public int PartId { get; set; }
        public int TaxId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public Tax Tax { get; set; }
    }
}
