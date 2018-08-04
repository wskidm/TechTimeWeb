using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ScheduleCannedJob
    {
        public int ScheduleCannedJobId { get; set; }
        public int ScheduleId { get; set; }
        public int? CannedJobId { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Time { get; set; }
        public decimal? Rate { get; set; }
        public bool IsFinished { get; set; }
        public bool IsCheckedIn { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public CannedJob CannedJob { get; set; }
        public Category Category { get; set; }
        public Schedule Schedule { get; set; }
    }
}
