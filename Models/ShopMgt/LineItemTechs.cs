using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LineItemTechs
    {
        public int LineItemTechsId { get; set; }
        public int LineItemId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? HoursActual { get; set; }
        public decimal? HoursPay { get; set; }
        public decimal? Commission { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Employee Employee { get; set; }
        public LineItem LineItem { get; set; }
    }
}
