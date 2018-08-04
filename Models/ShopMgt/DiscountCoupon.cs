using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class DiscountCoupon
    {
        public DiscountCoupon()
        {
            CouponItem = new HashSet<CouponItem>();
        }

        public int CouponId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? PartsOff { get; set; }
        public decimal? LaborOff { get; set; }
        public bool IsDeleted { get; set; }
        public int AmountTypeId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public DiscountAmountType AmountType { get; set; }
        public ICollection<CouponItem> CouponItem { get; set; }
    }
}
