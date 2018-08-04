using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class AccountClass
    {
        public AccountClass()
        {
            CouponItemLaborAccountClass = new HashSet<CouponItem>();
            CouponItemPartsAccountClass = new HashSet<CouponItem>();
            FeeSetting = new HashSet<FeeSetting>();
            FeeTransaction = new HashSet<FeeTransaction>();
            Glaccounts = new HashSet<Glaccounts>();
            LineItem = new HashSet<LineItem>();
            Part = new HashSet<Part>();
            PartKit = new HashSet<PartKit>();
            Payment = new HashSet<Payment>();
        }

        public int AccountClassId { get; set; }
        public string AccountType { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<CouponItem> CouponItemLaborAccountClass { get; set; }
        public ICollection<CouponItem> CouponItemPartsAccountClass { get; set; }
        public ICollection<FeeSetting> FeeSetting { get; set; }
        public ICollection<FeeTransaction> FeeTransaction { get; set; }
        public ICollection<Glaccounts> Glaccounts { get; set; }
        public ICollection<LineItem> LineItem { get; set; }
        public ICollection<Part> Part { get; set; }
        public ICollection<PartKit> PartKit { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
