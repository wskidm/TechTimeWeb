using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class StandardSymptom
    {
        public int StandardSymptomId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string WorkRequested { get; set; }
        public decimal? EstimatedLaborHours { get; set; }
        public decimal? EstimatedLaborCost { get; set; }
        public decimal? EstimatedPartsCost { get; set; }
        public bool UseFixedLaborRate { get; set; }
        public int? CategoryId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Category Category { get; set; }
    }
}
