using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Tax
    {
        public Tax()
        {
            CustomerTaxes = new HashSet<CustomerTaxes>();
            LineItemTaxes = new HashSet<LineItemTaxes>();
            PartTaxAssociation = new HashSet<PartTaxAssociation>();
            RepairOrderTaxSummary = new HashSet<RepairOrderTaxSummary>();
            RepairOrderTaxes = new HashSet<RepairOrderTaxes>();
            RevisionTaxSummary = new HashSet<RevisionTaxSummary>();
            TaxRates = new HashSet<TaxRates>();
            VehicleTaxes = new HashSet<VehicleTaxes>();
        }

        public int TaxId { get; set; }
        public string Description { get; set; }
        public int CalculationType { get; set; }
        public bool DefaultApplied { get; set; }
        public string Glcode { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public TaxCalculationTypes CalculationTypeNavigation { get; set; }
        public ICollection<CustomerTaxes> CustomerTaxes { get; set; }
        public ICollection<LineItemTaxes> LineItemTaxes { get; set; }
        public ICollection<PartTaxAssociation> PartTaxAssociation { get; set; }
        public ICollection<RepairOrderTaxSummary> RepairOrderTaxSummary { get; set; }
        public ICollection<RepairOrderTaxes> RepairOrderTaxes { get; set; }
        public ICollection<RevisionTaxSummary> RevisionTaxSummary { get; set; }
        public ICollection<TaxRates> TaxRates { get; set; }
        public ICollection<VehicleTaxes> VehicleTaxes { get; set; }
    }
}
