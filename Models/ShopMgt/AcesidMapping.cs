using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class AcesidMapping
    {
        public int AcesId { get; set; }
        public int AcesEngineId { get; set; }
        public int VehicleConfigurationId { get; set; }
        public int? AcesBaseId { get; set; }
        public int? AcesEngineConfigId { get; set; }
        public int? AcesSubModelId { get; set; }

        public VehicleConfigurationMapping VehicleConfiguration { get; set; }
    }
}
