using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Version
    {
        public DateTime DmvversionDate { get; set; }
        public int VersionNumber { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
