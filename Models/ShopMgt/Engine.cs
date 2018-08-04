using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Engine
    {
        public Engine()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int EngineId { get; set; }
        public float? DisplacementCid { get; set; }
        public float? DisplacementLiters { get; set; }
        public int? NumberOfCylinders { get; set; }
        public int? ValvesPerCylinder { get; set; }
        public string FuelDeliveryMethodType { get; set; }
        public string FuelType { get; set; }
        public string FuelControlType { get; set; }
        public string HeadConfigurationType { get; set; }
        public string BoostType { get; set; }
        public string IgnitionSystem { get; set; }
        public string VinCode { get; set; }
        public string FuelSystem { get; set; }
        public string BlockConfiguration { get; set; }
        public string FuelSystemConfiguration { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
