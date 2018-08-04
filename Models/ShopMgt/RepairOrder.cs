using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrder
    {
        public RepairOrder()
        {
            OrderRevision = new HashSet<OrderRevision>();
            Payment = new HashSet<Payment>();
            Podetail = new HashSet<Podetail>();
            RepairOrderLineItemSequence = new HashSet<RepairOrderLineItemSequence>();
            RepairOrderTaxSummary = new HashSet<RepairOrderTaxSummary>();
            RepairOrderTaxes = new HashSet<RepairOrderTaxes>();
            RepairOrderTechRates = new HashSet<RepairOrderTechRates>();
            RepairOrderTechs = new HashSet<RepairOrderTechs>();
            Schedule = new HashSet<Schedule>();
            Vdoc = new HashSet<Vdoc>();
        }

        public int RepairOrderId { get; set; }
        public int RepairOrderPhaseId { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public int? CategoryId { get; set; }
        public int? ReasonForVisitId { get; set; }
        public string Location { get; set; }
        public string StatusDescription { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public decimal ScheduledHours { get; set; }
        public DateTime? PromiseDate { get; set; }
        public bool RoPrinted { get; set; }
        public bool InvoicePrinted { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string Hat { get; set; }
        public DateTime? DatePosted { get; set; }
        public int? OdometerIn { get; set; }
        public int? OdometerOut { get; set; }
        public string ReferenceNumber { get; set; }
        public bool CalculateHazWasteCost { get; set; }
        public bool CalculateShopSuppliesCost { get; set; }
        public decimal? TaxAmtHazMat { get; set; }
        public decimal? TaxAmtShopSupplies { get; set; }
        public DateTime? PrintedDate { get; set; }
        public int PartDiscountDescriptionId { get; set; }
        public bool TaxExempt { get; set; }
        public int LaborRateDescriptionId { get; set; }
        public DateTime RateVersionDate { get; set; }
        public bool FromQuickEst { get; set; }
        public string Notes { get; set; }
        public decimal? OrderTotal { get; set; }
        public decimal? HazWasteAmt { get; set; }
        public decimal? ShopSuppliesAmt { get; set; }
        public decimal? TotalTaxAmt { get; set; }
        public decimal? LaborSale { get; set; }
        public decimal? PartsSale { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string Observations { get; set; }
        public bool CreatedAsEstimate { get; set; }
        public decimal BalanceDueAdjustment { get; set; }
        public byte[] Timestamp { get; set; }
        public decimal? MarginPct { get; set; }
        public decimal? TireFeeSale { get; set; }
        public decimal EngineHoursIn { get; set; }
        public decimal EngineHoursOut { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
        public Customers Cust { get; set; }
        public LaborRateDescription LaborRateDescription { get; set; }
        public PartDiscountDescription PartDiscountDescription { get; set; }
        public ReasonForVisit ReasonForVisit { get; set; }
        public RepairOrderPhase RepairOrderPhase { get; set; }
        public Vehicle Vehicle { get; set; }
        public Estimate Estimate { get; set; }
        public RecordNumber RecordNumber { get; set; }
        public ICollection<OrderRevision> OrderRevision { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<Podetail> Podetail { get; set; }
        public ICollection<RepairOrderLineItemSequence> RepairOrderLineItemSequence { get; set; }
        public ICollection<RepairOrderTaxSummary> RepairOrderTaxSummary { get; set; }
        public ICollection<RepairOrderTaxes> RepairOrderTaxes { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRates { get; set; }
        public ICollection<RepairOrderTechs> RepairOrderTechs { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
        public ICollection<Vdoc> Vdoc { get; set; }
    }
}
