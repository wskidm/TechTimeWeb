using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class EndOfDayReports
    {
        public int ReportId { get; set; }
        public bool IsTagged { get; set; }
        public int EndOfDayReportsId { get; set; }
        public int RecordVersion { get; set; }

        public ReportDefinition Report { get; set; }
    }
}
