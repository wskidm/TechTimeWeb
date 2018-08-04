using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class PaymentTransaction
    {
        public PaymentTransaction()
        {
            Payment = new HashSet<Payment>();
        }

        public int PaymentTransactionId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
