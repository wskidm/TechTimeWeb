using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class QuickClose
    {
        public QuickClose()
        {
            Alert = new HashSet<Alert>();
        }

        public int QuickCloseId { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public int? ServiceWriterId { get; set; }
        public string CustomerComments { get; set; }
        public string ShopComments { get; set; }
        public DateTime Closed { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
        public Employee ServiceWriter { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<Alert> Alert { get; set; }
    }
}
