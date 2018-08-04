using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class DbVersion
    {
        public int DbVersionId { get; set; }
        public string DbVersionNumber { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public int RecordVersion { get; set; }
    }
}
