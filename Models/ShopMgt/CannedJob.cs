using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CannedJob
    {
        public CannedJob()
        {
            CannedJobLineItemSequence = new HashSet<CannedJobLineItemSequence>();
            CannedJobPartKitSequence = new HashSet<CannedJobPartKitSequence>();
            LineItem = new HashSet<LineItem>();
            ScheduleCannedJob = new HashSet<ScheduleCannedJob>();
        }

        public int CannedJobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? Year { get; set; }
        public int? MakeId { get; set; }
        public int? SubModelId { get; set; }
        public bool InQuickMenu { get; set; }
        public byte[] Timestamp { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? VehicleClass { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
        public Make MakeNavigation { get; set; }
        public SubModel SubModel { get; set; }
        public ICollection<CannedJobLineItemSequence> CannedJobLineItemSequence { get; set; }
        public ICollection<CannedJobPartKitSequence> CannedJobPartKitSequence { get; set; }
        public ICollection<LineItem> LineItem { get; set; }
        public ICollection<ScheduleCannedJob> ScheduleCannedJob { get; set; }
    }
}
