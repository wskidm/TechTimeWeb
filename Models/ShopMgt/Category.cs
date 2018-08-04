using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Category
    {
        public Category()
        {
            CannedJob = new HashSet<CannedJob>();
            LineItem = new HashSet<LineItem>();
            Package = new HashSet<Package>();
            Part = new HashSet<Part>();
            PartDescription = new HashSet<PartDescription>();
            PartKit = new HashSet<PartKit>();
            Recommendations = new HashSet<Recommendations>();
            RepairOrder = new HashSet<RepairOrder>();
            Schedule = new HashSet<Schedule>();
            ScheduleCannedJob = new HashSet<ScheduleCannedJob>();
            StandardSymptom = new HashSet<StandardSymptom>();
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool Display { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<CannedJob> CannedJob { get; set; }
        public ICollection<LineItem> LineItem { get; set; }
        public ICollection<Package> Package { get; set; }
        public ICollection<Part> Part { get; set; }
        public ICollection<PartDescription> PartDescription { get; set; }
        public ICollection<PartKit> PartKit { get; set; }
        public ICollection<Recommendations> Recommendations { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
        public ICollection<ScheduleCannedJob> ScheduleCannedJob { get; set; }
        public ICollection<StandardSymptom> StandardSymptom { get; set; }
    }
}
