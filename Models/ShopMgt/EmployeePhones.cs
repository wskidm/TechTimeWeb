using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class EmployeePhones
    {
        public int PhoneId { get; set; }
        public int EmployeeId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Employee Employee { get; set; }
        public PhoneNum Phone { get; set; }
    }
}
