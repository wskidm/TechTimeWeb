using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PackageCommission
    {
        public int PackageCommissionId { get; set; }
        public int PackageId { get; set; }
        public decimal Amount { get; set; }
        public decimal PayHours { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Package Package { get; set; }
    }
}
