using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CatalogVehicleAttributes
    {
        public int VehicleId { get; set; }
        public string CatKey { get; set; }
        public string CatValue { get; set; }
        public int RecordVersion { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
