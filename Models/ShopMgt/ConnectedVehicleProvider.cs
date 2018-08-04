using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ConnectedVehicleProvider
    {
        public ConnectedVehicleProvider()
        {
            Alert = new HashSet<Alert>();
            VehicleTelemetry = new HashSet<VehicleTelemetry>();
        }

        public int ConnectedVehicleProviderId { get; set; }
        public string SubProgram { get; set; }
        public string Program { get; set; }
        public int? CustId { get; set; }
        public int? VehicleId { get; set; }
        public string Vin { get; set; }
        public int Status { get; set; }
        public DateTime Received { get; set; }
        public DateTime? StatusChanged { get; set; }
        public string XmlData { get; set; }
        public int RecordVersion { get; set; }

        public Customers Cust { get; set; }
        public Vehicle Vehicle { get; set; }
        public ICollection<Alert> Alert { get; set; }
        public ICollection<VehicleTelemetry> VehicleTelemetry { get; set; }
    }
}
