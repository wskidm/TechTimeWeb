using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class AttachedPart
    {
        public int AttachedPartId { get; set; }
        public int PartId { get; set; }
        public int PartIdAttached { get; set; }
        public decimal Qty { get; set; }
        public bool Prompt { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public Part PartIdAttachedNavigation { get; set; }
    }
}
