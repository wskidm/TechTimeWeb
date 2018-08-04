using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class BodyStyle
    {
        public BodyStyle()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int BodyStyleId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
