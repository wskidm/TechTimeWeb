using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PhoneNum
    {
        public PhoneNum()
        {
            Vehicle = new HashSet<Vehicle>();
            VendorPhones = new HashSet<VendorPhones>();
        }

        public int PhoneId { get; set; }
        public int PhoneDescId { get; set; }
        public string PhoneNum1 { get; set; }
        public string Ext { get; set; }
        public bool? Display { get; set; }
        public byte[] Timestamp { get; set; }
        public string Note { get; set; }
        public int RecordVersion { get; set; }

        public PhoneDesc PhoneDesc { get; set; }
        public CustomerPhones CustomerPhones { get; set; }
        public EmployeePhones EmployeePhones { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
        public ICollection<VendorPhones> VendorPhones { get; set; }
    }
}
