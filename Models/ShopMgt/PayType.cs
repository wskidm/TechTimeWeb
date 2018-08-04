﻿using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PayType
    {
        public PayType()
        {
            Employee = new HashSet<Employee>();
            RepairOrderTechRates = new HashSet<RepairOrderTechRates>();
        }

        public int PayTypeId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Employee> Employee { get; set; }
        public ICollection<RepairOrderTechRates> RepairOrderTechRates { get; set; }
    }
}
