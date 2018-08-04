using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class InvoiceStatus
    {
        public InvoiceStatus()
        {
            Payment = new HashSet<Payment>();
        }

        public int InvoiceStatusId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
