using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class TaxRates
    {
        public TaxRates()
        {
            RepairOrderTaxSummary = new HashSet<RepairOrderTaxSummary>();
            RevisionTaxSummary = new HashSet<RevisionTaxSummary>();
        }

        public int TaxRateId { get; set; }
        public int TaxId { get; set; }
        public DateTime VersionDate { get; set; }
        public decimal MatlRate { get; set; }
        public decimal LaborRate { get; set; }
        public byte[] Timestamp { get; set; }
        public int StateCalculation { get; set; }
        public int RecordVersion { get; set; }

        public Tax Tax { get; set; }
        public ICollection<RepairOrderTaxSummary> RepairOrderTaxSummary { get; set; }
        public ICollection<RevisionTaxSummary> RevisionTaxSummary { get; set; }
    }
}
