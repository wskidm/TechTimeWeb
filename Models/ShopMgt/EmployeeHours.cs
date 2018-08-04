using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class EmployeeHours
    {
        public int EmployeeHoursId { get; set; }
        public int EmployeeId { get; set; }
        public int DayOfWeek { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Employee Employee { get; set; }
    }
}
