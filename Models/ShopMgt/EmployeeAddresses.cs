using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class EmployeeAddresses
    {
        public int AddressId { get; set; }
        public int EmployeeId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Addresses Address { get; set; }
        public Employee Employee { get; set; }
    }
}
