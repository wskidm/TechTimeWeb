using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class FeeTransaction
    {
        public int FeeTransactionId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public int? AccountClassId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? FeeBalance { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AccountClass { get; set; }
        public Customers Customer { get; set; }
    }
}
