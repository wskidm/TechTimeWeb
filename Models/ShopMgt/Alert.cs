using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Alert
    {
        public int AlertId { get; set; }
        public int ConnectedVehicleProviderId { get; set; }
        public int? ScheduleId { get; set; }
        public int? QuickCloseId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string Dtc { get; set; }
        public int Status { get; set; }
        public int? Mileage { get; set; }
        public int? MileageUnits { get; set; }
        public DateTime? Resolved { get; set; }
        public DateTime Submitted { get; set; }
        public int RecordVersion { get; set; }

        public ConnectedVehicleProvider ConnectedVehicleProvider { get; set; }
        public QuickClose QuickClose { get; set; }
        public Schedule Schedule { get; set; }
    }
}
