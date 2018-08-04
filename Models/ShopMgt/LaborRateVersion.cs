using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LaborRateVersion
    {
        public int LaborRateVersionId { get; set; }
        public int LaborRateDescriptionId { get; set; }
        public decimal LaborRate { get; set; }
        public DateTime VersionDate { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LaborRateDescription LaborRateDescription { get; set; }
    }
}
