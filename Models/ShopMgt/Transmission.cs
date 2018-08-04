using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Transmission
    {
        public Transmission()
        {
            ShopMgtVehicleConfig = new HashSet<ShopMgtVehicleConfig>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int TransmissionId { get; set; }
        public string TransmissionType { get; set; }
        public string ManufacturerCode { get; set; }
        public string ControlType { get; set; }
        public bool? ElectronicControlled { get; set; }
        public int? NumberOfSpeeds { get; set; }
        public byte[] Timestamp { get; set; }

        public ICollection<ShopMgtVehicleConfig> ShopMgtVehicleConfig { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
