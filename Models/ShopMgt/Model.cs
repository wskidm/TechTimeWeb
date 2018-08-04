using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Model
    {
        public Model()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            SubModel = new HashSet<SubModel>();
        }

        public int ModelId { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }

        public Make Make { get; set; }
        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<SubModel> SubModel { get; set; }
    }
}
