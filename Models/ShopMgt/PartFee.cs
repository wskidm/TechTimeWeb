using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartFee
    {
        public PartFee()
        {
            Part = new HashSet<Part>();
        }

        public int PartFeeId { get; set; }
        public int LineItemId { get; set; }
        public bool Prompt { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
        public ICollection<Part> Part { get; set; }
    }
}
