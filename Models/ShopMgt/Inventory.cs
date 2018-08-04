using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int PartId { get; set; }
        public decimal OnHand { get; set; }
        public decimal OnOrder { get; set; }
        public string Location { get; set; }
        public DateTime? LastSold { get; set; }
        public decimal CommittedQty { get; set; }
        public int? ConditionId { get; set; }
        public int? SupercededBy { get; set; }
        public decimal? RestockQty { get; set; }
        public decimal? OrderPoint { get; set; }
        public int CoreQty { get; set; }
        public bool? PayCommission { get; set; }
        public decimal TotalCost { get; set; }
        public decimal LastCost { get; set; }
        public decimal PriorToLastCost { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
        public decimal AvailableQty { get; set; }

        public InventoryCondition Condition { get; set; }
        public Part Part { get; set; }
        public Part SupercededByNavigation { get; set; }
    }
}
