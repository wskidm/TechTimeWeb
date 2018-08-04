using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleTaxes
    {
        public int VehicleId { get; set; }
        public int TaxId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Tax Tax { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
