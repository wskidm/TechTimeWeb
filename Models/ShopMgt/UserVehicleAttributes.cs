using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class UserVehicleAttributes
    {
        public int UserAttributeId { get; set; }
        public int VehicleId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public bool Ymmselector { get; set; }
        public int RecordVersion { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
