using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LineItemTaxes
    {
        public int LineItemId { get; set; }
        public int TaxId { get; set; }
        public decimal TaxCharged { get; set; }
        public decimal TaxedTaxes { get; set; }
        public decimal TaxRate { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public Tax Tax { get; set; }
    }
}
