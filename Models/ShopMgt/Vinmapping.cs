using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Vinmapping
    {
        public string Vincode { get; set; }
        public int VehicleConfigurationId { get; set; }
        public byte[] Timestamp { get; set; }

        public VehicleConfigurationMapping VehicleConfiguration { get; set; }
    }
}
