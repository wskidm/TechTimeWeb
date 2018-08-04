using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class AlternatePartPrice
    {
        public int AlternatePartPriceId { get; set; }
        public int PartId { get; set; }
        public int PartDiscountDescriptionId { get; set; }
        public decimal Price { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public PartDiscountDescription PartDiscountDescription { get; set; }
    }
}
