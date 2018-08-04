using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        public int TransactionTypeId { get; set; }
        public int? VendorId { get; set; }
        public decimal Cost { get; set; }
        public decimal QuantityDelta { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string Reason { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? PartId { get; set; }
        public decimal? QuantityBeforeTransaction { get; set; }
        public decimal? QuantityAfterTransaction { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Part Part { get; set; }
        public TransactionType TransactionType { get; set; }
        public Vendor Vendor { get; set; }
    }
}
