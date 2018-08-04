using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CannedJobLineItemSequence
    {
        public int CannedJobId { get; set; }
        public int LineItem { get; set; }
        public int Sequence { get; set; }
        public byte[] Timestamp { get; set; }
        public int CannedJobLineItemSequenceId { get; set; }
        public int RecordVersion { get; set; }

        public CannedJob CannedJob { get; set; }
        public LineItem LineItemNavigation { get; set; }
    }
}
