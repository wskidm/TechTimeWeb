using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Gvw
    {
        public Gvw()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int Gvwid { get; set; }
        public string Gvwtext { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
