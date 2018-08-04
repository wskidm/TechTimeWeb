using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CatalogVehicleLink
    {
        public int CatalogLinkId { get; set; }
        public int VehicleId { get; set; }
        public string Value { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public CatalogLink CatalogLink { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
