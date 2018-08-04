using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReportRoprefs
    {
        public int ReportRoprefsId { get; set; }
        public int ReportId { get; set; }
        public bool? ShowHeader { get; set; }
        public bool? ShowComment { get; set; }
        public bool? ShowSignature { get; set; }
        public int? NumCopies { get; set; }
        public int? RoreportType { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
