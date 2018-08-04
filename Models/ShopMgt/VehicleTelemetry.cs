using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleTelemetry
    {
        public int VehicleTelemetryId { get; set; }
        public int ConnectedVehicleProviderId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public int? Mileage { get; set; }
        public int? MileageUnits { get; set; }
        public decimal? BatteryVoltage { get; set; }
        public DateTime Submitted { get; set; }
        public int RecordVersion { get; set; }

        public ConnectedVehicleProvider ConnectedVehicleProvider { get; set; }
    }
}
