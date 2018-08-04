using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleLocation
    {
        public int VehicleLocationId { get; set; }
        public string Location { get; set; }
        public bool Flagged { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
