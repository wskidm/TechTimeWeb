using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PartDiscountDescription
    {
        public PartDiscountDescription()
        {
            AlternatePartPrice = new HashSet<AlternatePartPrice>();
            Customers = new HashSet<Customers>();
            PartDiscountVersion = new HashSet<PartDiscountVersion>();
            PartItem = new HashSet<PartItem>();
            RepairOrder = new HashSet<RepairOrder>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int PartDiscountDescriptionId { get; set; }
        public string Description { get; set; }
        public bool PartDiscountDefault { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<AlternatePartPrice> AlternatePartPrice { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<PartDiscountVersion> PartDiscountVersion { get; set; }
        public ICollection<PartItem> PartItem { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
