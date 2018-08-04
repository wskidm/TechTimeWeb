using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderTaxSummary
    {
        public int RepairOrderId { get; set; }
        public int TaxId { get; set; }
        public int TaxRateId { get; set; }
        public decimal MatlTaxCharged { get; set; }
        public decimal LaborTaxCharged { get; set; }
        public decimal TotalTaxCharged { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
        public Tax Tax { get; set; }
        public TaxRates TaxRate { get; set; }
    }
}
