using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReasonForVisit
    {
        public ReasonForVisit()
        {
            RepairOrder = new HashSet<RepairOrder>();
            Schedule = new HashSet<Schedule>();
        }

        public int ReasonForVisitId { get; set; }
        public string Reason { get; set; }
        public byte[] Timestamp { get; set; }
        public bool IsDeleted { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
    }
}
