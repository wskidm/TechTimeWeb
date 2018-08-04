using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class GroupAssociation
    {
        public int GroupId { get; set; }
        public int CustId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
        public Groups Group { get; set; }
    }
}
