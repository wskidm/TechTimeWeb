using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CouponItem
    {
        public int LineItemId { get; set; }
        public decimal LaborDiscountAmount { get; set; }
        public decimal PartDiscountAmount { get; set; }
        public bool IsPercentage { get; set; }
        public byte[] Timestamp { get; set; }
        public int? CouponId { get; set; }
        public decimal ActualLaborDiscount { get; set; }
        public decimal ActualPartsDiscount { get; set; }
        public int? LaborAccountClassId { get; set; }
        public int? PartsAccountClassId { get; set; }
        public int RecordVersion { get; set; }

        public DiscountCoupon Coupon { get; set; }
        public AccountClass LaborAccountClass { get; set; }
        public LineItem LineItem { get; set; }
        public AccountClass PartsAccountClass { get; set; }
    }
}
