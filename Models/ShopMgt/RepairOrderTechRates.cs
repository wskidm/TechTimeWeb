using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderTechRates
    {
        public int RepairOrderId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeType { get; set; }
        public decimal CommParts { get; set; }
        public decimal CommLabor { get; set; }
        public decimal CommSublet { get; set; }
        public decimal WageAmount { get; set; }
        public decimal PayPeriodHours { get; set; }
        public int PayTypeId { get; set; }
        public int CommTypeParts { get; set; }
        public int CommTypeLabor { get; set; }
        public int CommTypeSublet { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public CommissionType CommTypeLaborNavigation { get; set; }
        public CommissionType CommTypePartsNavigation { get; set; }
        public CommissionType CommTypeSubletNavigation { get; set; }
        public Employee Employee { get; set; }
        public EmployeeType EmployeeTypeNavigation { get; set; }
        public PayType PayType { get; set; }
        public RepairOrder RepairOrder { get; set; }
    }
}
