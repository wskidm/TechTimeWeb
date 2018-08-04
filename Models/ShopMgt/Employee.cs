using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeAddresses = new HashSet<EmployeeAddresses>();
            EmployeeHours = new HashSet<EmployeeHours>();
            EmployeePhones = new HashSet<EmployeePhones>();
            LineItemTechs = new HashSet<LineItemTechs>();
            OrderRevision = new HashSet<OrderRevision>();
            Pomaster = new HashSet<Pomaster>();
            QuickClose = new HashSet<QuickClose>();
            RepairOrderTechRates = new HashSet<RepairOrderTechRates>();
            RepairOrderTechs = new HashSet<RepairOrderTechs>();
            ScheduleEmployee = new HashSet<Schedule>();
            ScheduleServiceWriter = new HashSet<Schedule>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int EmployeeTypeId { get; set; }
        public string AccountingId { get; set; }
        public decimal CommParts { get; set; }
        public decimal CommLabor { get; set; }
        public decimal CommSublet { get; set; }
        public decimal WageAmount { get; set; }
        public decimal PayPeriodHours { get; set; }
        public int PayTypeId { get; set; }
        public int CommTypeParts { get; set; }
        public int CommTypeLabor { get; set; }
        public int CommTypeSublet { get; set; }
        public bool Deleted { get; set; }
        public byte[] Timestamp { get; set; }
        public int? ColorValue { get; set; }
        public string Notes { get; set; }
        public DateTime? Dob { get; set; }
        public bool Inactive { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? HiredDate { get; set; }
        public DateTime? LastPayRaiseDate { get; set; }
        public DateTime? DischargedDate { get; set; }
        public int RecordVersion { get; set; }

        public CommissionType CommTypeLaborNavigation { get; set; }
        public CommissionType CommTypePartsNavigation { get; set; }
        public CommissionType CommTypeSubletNavigation { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public PayType PayType { get; set; }
        public ICollection<EmployeeAddresses> EmployeeAddresses { get; set; }
        public ICollection<EmployeeHours> EmployeeHours { get; set; }
        public ICollection<EmployeePhones> EmployeePhones { get; set; }
        public ICollection<LineItemTechs> LineItemTechs { get; set; }
        public ICollection<OrderRevision> OrderRevision { get; set; }
        public ICollection<Pomaster> Pomaster { get; set; }
        public ICollection<QuickClose> QuickClose { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRates { get; set; }
        public ICollection<RepairOrderTechs> RepairOrderTechs { get; set; }
        public ICollection<Schedule> ScheduleEmployee { get; set; }
        public ICollection<Schedule> ScheduleServiceWriter { get; set; }
    }
}
