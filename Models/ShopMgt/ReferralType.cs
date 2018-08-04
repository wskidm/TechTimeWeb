using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReferralType
    {
        public ReferralType()
        {
            Customers = new HashSet<Customers>();
        }

        public int RefTypeId { get; set; }
        public string TypeName { get; set; }
        public bool? HasCustId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
