using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Drive
    {
        public Drive()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int DriveId { get; set; }
        public string DriveType { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
