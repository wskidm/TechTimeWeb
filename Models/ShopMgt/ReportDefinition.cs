using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReportDefinition
    {
        public ReportDefinition()
        {
            EndOfDayReports = new HashSet<EndOfDayReports>();
            ReportParams = new HashSet<ReportParams>();
            ReportsUnclassified = new HashSet<ReportsUnclassified>();
        }

        public int ReportId { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public int ReportTypeId { get; set; }
        public int ReportClassId { get; set; }
        public bool DisplayShopLogo { get; set; }
        public bool ShowReport { get; set; }
        public int SortIndex { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ReportClass ReportClass { get; set; }
        public ReportType ReportType { get; set; }
        public ICollection<EndOfDayReports> EndOfDayReports { get; set; }
        public ICollection<ReportParams> ReportParams { get; set; }
        public ICollection<ReportsUnclassified> ReportsUnclassified { get; set; }
    }
}
