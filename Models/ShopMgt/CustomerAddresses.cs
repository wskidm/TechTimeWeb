using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CustomerAddresses
    {
        public int AddressId { get; set; }
        public int CustId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Addresses Address { get; set; }
        public Customers Cust { get; set; }
    }
}
