using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CustomerPhones
    {
        public CustomerPhones()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int PhoneId { get; set; }
        public int CustId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
        public PhoneNum Phone { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
    }
}
