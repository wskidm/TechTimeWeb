using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Addresses
    {
        public Addresses()
        {
            VendorAddresses = new HashSet<VendorAddresses>();
        }

        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public AddressType AddressType { get; set; }
        public CustomerAddresses CustomerAddresses { get; set; }
        public EmployeeAddresses EmployeeAddresses { get; set; }
        public ICollection<VendorAddresses> VendorAddresses { get; set; }
    }
}
