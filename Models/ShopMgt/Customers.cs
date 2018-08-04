using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Customers
    {
        public Customers()
        {
            ConnectedVehicleProvider = new HashSet<ConnectedVehicleProvider>();
            CustomerAddresses = new HashSet<CustomerAddresses>();
            CustomerPhones = new HashSet<CustomerPhones>();
            CustomerTaxes = new HashSet<CustomerTaxes>();
            CustomerYtdadjustment = new HashSet<CustomerYtdadjustment>();
            FeeTransaction = new HashSet<FeeTransaction>();
            GroupAssociation = new HashSet<GroupAssociation>();
            Payment = new HashSet<Payment>();
            QuickClose = new HashSet<QuickClose>();
            RepairOrder = new HashSet<RepairOrder>();
            Schedule = new HashSet<Schedule>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int CustId { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string SpouseName { get; set; }
        public string JobTitle { get; set; }
        public int? PartLevel { get; set; }
        public int? LaborLevel { get; set; }
        public bool? ChargeOk { get; set; }
        public string Remarks { get; set; }
        public string ResaleNum { get; set; }
        public bool? IncludeInCrmcampaign { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? FeeAssessmentDate { get; set; }
        public decimal CurrentFeeAmount { get; set; }
        public bool NoLateFee { get; set; }
        public DateTime? NewCustFollowUpDate { get; set; }
        public bool? EmailReminder { get; set; }
        public int? RefById { get; set; }
        public int? RefTypeId { get; set; }
        public bool TaxExempt { get; set; }
        public DateTime? LastVisited { get; set; }
        public DateTime? FirstVisited { get; set; }
        public int DeletedRepairOrderCount { get; set; }
        public decimal RepairOrderAdjustment { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? CreditAmt { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] Timestamp { get; set; }
        public bool IsFromSchedule { get; set; }
        public string MembershipNo { get; set; }
        public int RecordVersion { get; set; }

        public LaborRateDescription LaborLevelNavigation { get; set; }
        public PartDiscountDescription PartLevelNavigation { get; set; }
        public ReferralType RefType { get; set; }
        public CustTitle Title { get; set; }
        public ICollection<ConnectedVehicleProvider> ConnectedVehicleProvider { get; set; }
        public ICollection<CustomerAddresses> CustomerAddresses { get; set; }
        public ICollection<CustomerPhones> CustomerPhones { get; set; }
        public ICollection<CustomerTaxes> CustomerTaxes { get; set; }
        public ICollection<CustomerYtdadjustment> CustomerYtdadjustment { get; set; }
        public ICollection<FeeTransaction> FeeTransaction { get; set; }
        public ICollection<GroupAssociation> GroupAssociation { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<QuickClose> QuickClose { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
