using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartNumber
    {
        public int PartNumberId { get; set; }
        public int PartId { get; set; }
        public bool? IsBasePart { get; set; }
        public string PartNumber1 { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
    }
}
