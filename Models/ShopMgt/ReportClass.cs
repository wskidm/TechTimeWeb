using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReportClass
    {
        public ReportClass()
        {
            ReportDefinition = new HashSet<ReportDefinition>();
        }

        public int ReportClassId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<ReportDefinition> ReportDefinition { get; set; }
    }
}
