using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Make
    {
        public Make()
        {
            CannedJob = new HashSet<CannedJob>();
            Model = new HashSet<Model>();
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int MakeId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<CannedJob> CannedJob { get; set; }
        public ICollection<Model> Model { get; set; }
        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
