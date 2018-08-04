using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ReportParams
    {
        public int ReportParamsId { get; set; }
        public int ReportId { get; set; }
        public string ParamName { get; set; }
        public string ParamVal { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ReportDefinition Report { get; set; }
    }
}
