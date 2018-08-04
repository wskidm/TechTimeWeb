using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class DecodedVehicleIds
    {
        public int VehicleId { get; set; }
        public byte[] TimeStamp { get; set; }
        public int DecodedVehicleIdsId { get; set; }
        public int RecordVersion { get; set; }
    }
}
