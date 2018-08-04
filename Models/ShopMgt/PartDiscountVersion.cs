using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartDiscountVersion
    {
        public int PartDiscountVersionId { get; set; }
        public int PartDiscountDescriptionId { get; set; }
        public decimal PartDiscount { get; set; }
        public DateTime VersionDate { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public PartDiscountDescription PartDiscountDescription { get; set; }
    }
}
