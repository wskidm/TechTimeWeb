using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RevisionLineItemSequence
    {
        public int OrderRevisionId { get; set; }
        public int LineItemId { get; set; }
        public int Sequence { get; set; }
        public byte[] Timestamp { get; set; }
        public int RevisionLineItemSequenceId { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public OrderRevision OrderRevision { get; set; }
    }
}
