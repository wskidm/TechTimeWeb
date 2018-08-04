using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class InventoryCondition
    {
        public InventoryCondition()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int ConditionId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }
}
