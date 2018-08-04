using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Brake
    {
        public Brake()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int BrakeId { get; set; }
        public string BrakeSystemType { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
