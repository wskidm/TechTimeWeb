using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RevisionTaxSummary
    {
        public int OrderRevisionId { get; set; }
        public int TaxId { get; set; }
        public int TaxRateId { get; set; }
        public decimal MatlTaxCharged { get; set; }
        public decimal LaborTaxCharged { get; set; }
        public decimal ShopSuppliesTaxCharged { get; set; }
        public decimal HazMatTaxCharged { get; set; }
        public decimal TotalTaxCharged { get; set; }
        public byte[] Timestamp { get; set; }
        public int RevisionTaxSummaryId { get; set; }
        public int HazMatLineItemType { get; set; }
        public int RecordVersion { get; set; }

        public OrderRevision OrderRevision { get; set; }
        public Tax Tax { get; set; }
        public TaxRates TaxRate { get; set; }
    }
}
