using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PhoneDesc
    {
        public PhoneDesc()
        {
            PhoneNum = new HashSet<PhoneNum>();
        }

        public int PhoneDescId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<PhoneNum> PhoneNum { get; set; }
    }
}
