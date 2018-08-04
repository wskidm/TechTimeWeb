using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CommissionType
    {
        public CommissionType()
        {
            EmployeeCommTypeLaborNavigation = new HashSet<Employee>();
            EmployeeCommTypePartsNavigation = new HashSet<Employee>();
            EmployeeCommTypeSubletNavigation = new HashSet<Employee>();
            RepairOrderTechRatesCommTypeLaborNavigation = new HashSet<RepairOrderTechRates>();
            RepairOrderTechRatesCommTypePartsNavigation = new HashSet<RepairOrderTechRates>();
            RepairOrderTechRatesCommTypeSubletNavigation = new HashSet<RepairOrderTechRates>();
        }

        public int CommissionTypeId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Employee> EmployeeCommTypeLaborNavigation { get; set; }
        public ICollection<Employee> EmployeeCommTypePartsNavigation { get; set; }
        public ICollection<Employee> EmployeeCommTypeSubletNavigation { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRatesCommTypeLaborNavigation { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRatesCommTypePartsNavigation { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRatesCommTypeSubletNavigation { get; set; }
    }
}
