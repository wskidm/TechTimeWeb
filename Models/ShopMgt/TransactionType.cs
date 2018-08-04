using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            InventoryTransaction = new HashSet<InventoryTransaction>();
        }

        public int TransactionTypeId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<InventoryTransaction> InventoryTransaction { get; set; }
    }
}
