using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Markup
    {
        public int MarkupId { get; set; }
        public decimal MaxRange { get; set; }
        public decimal Percentage { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
