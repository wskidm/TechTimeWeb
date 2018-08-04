using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class OrderRevision
    {
        public OrderRevision()
        {
            LineItem = new HashSet<LineItem>();
            PodetailRevision = new HashSet<PodetailRevision>();
            RevisionLineItemSequence = new HashSet<RevisionLineItemSequence>();
            RevisionTaxSummary = new HashSet<RevisionTaxSummary>();
        }

        public int OrderRevisionId { get; set; }
        public int? RepairOrderId { get; set; }
        public int? SubEstimateNumber { get; set; }
        public DateTime RevisionDate { get; set; }
        public DateTime? TimeOfCall { get; set; }
        public string InitiatedBy { get; set; }
        public int? WriterId { get; set; }
        public string AuthorizedBy { get; set; }
        public string NumberCalled { get; set; }
        public string Reason { get; set; }
        public decimal? CurrentEstimate { get; set; }
        public decimal RevisionAmount { get; set; }
        public int? VehicleId { get; set; }
        public decimal LaborAmount { get; set; }
        public decimal PartsAmount { get; set; }
        public decimal SubletAmount { get; set; }
        public byte[] Timestamp { get; set; }
        public decimal HazWasteAmt { get; set; }
        public decimal ShopSuppliesAmt { get; set; }
        public decimal TaxAmtHazMat { get; set; }
        public decimal TaxAmtShopSupplies { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal TaxCharged { get; set; }
        public decimal? TireFeeAmount { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
        public Vehicle Vehicle { get; set; }
        public Employee Writer { get; set; }
        public ICollection<LineItem> LineItem { get; set; }
        public ICollection<PodetailRevision> PodetailRevision { get; set; }
        public ICollection<RevisionLineItemSequence> RevisionLineItemSequence { get; set; }
        public ICollection<RevisionTaxSummary> RevisionTaxSummary { get; set; }
    }
}
