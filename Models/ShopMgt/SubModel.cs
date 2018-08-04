using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SubModel
    {
        public SubModel()
        {
            CannedJob = new HashSet<CannedJob>();
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int SubModelId { get; set; }
        public int ModelId { get; set; }
        public string Name { get; set; }
        public int? Dmvid { get; set; }
        public byte[] Timestamp { get; set; }

        public Model Model { get; set; }
        public ICollection<CannedJob> CannedJob { get; set; }
        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
