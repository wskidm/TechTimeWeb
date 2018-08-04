using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ExtractionStatus
    {
        public int ExtractionStatusId { get; set; }
        public string ProductName { get; set; }
        public short InitialExtractDone { get; set; }
        public byte[] LastExtractionStamp { get; set; }
        public byte[] TempExtractionStamp { get; set; }
    }
}
