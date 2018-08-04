using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CustomerTaxes
    {
        public int CustId { get; set; }
        public int TaxId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
        public Tax Tax { get; set; }
    }
}
