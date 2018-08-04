using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class DiscountAmountType
    {
        public DiscountAmountType()
        {
            DiscountCoupon = new HashSet<DiscountCoupon>();
        }

        public int AmountTypeId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<DiscountCoupon> DiscountCoupon { get; set; }
    }
}
