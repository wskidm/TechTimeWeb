using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReportsUnclassified
    {
        public int ReportsUnclassifiedId { get; set; }
        public int ReportId { get; set; }
        public int RecordVersion { get; set; }

        public ReportDefinition Report { get; set; }
    }
}
