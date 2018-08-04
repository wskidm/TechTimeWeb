using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartKitParts
    {
        public int PartKitPartsId { get; set; }
        public int PartKitId { get; set; }
        public int PartId { get; set; }
        public decimal? Quantity { get; set; }
        public bool Prompt { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public PartKit PartKit { get; set; }
    }
}
