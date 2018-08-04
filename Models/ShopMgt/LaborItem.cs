using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LaborItem
    {
        public int LaborItemId { get; set; }
        public int LineItemId { get; set; }
        public int? LaborRateDescriptionId { get; set; }
        public bool IsUserEnteredLaborRate { get; set; }
        public string WorkPerformed { get; set; }
        public decimal? HoursCharged { get; set; }
        public string Symptom { get; set; }
        public int? ComeBackInvoice { get; set; }
        public decimal PartsEstimate { get; set; }
        public bool IsMplgItem { get; set; }
        public bool IsChangedMplgItem { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LaborRateDescription LaborRateDescription { get; set; }
        public LineItem LineItem { get; set; }
    }
}
