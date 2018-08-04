using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ScheduleStatus
    {
        public ScheduleStatus()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int StatusId { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Color { get; set; }
        public bool? IsActive { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Schedule> Schedule { get; set; }
    }
}
