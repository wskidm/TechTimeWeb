using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleConfigurationMapping
    {
        public VehicleConfigurationMapping()
        {
            AaiaidMapping = new HashSet<AaiaidMapping>();
            AcesidMapping = new HashSet<AcesidMapping>();
            Vinmapping = new HashSet<Vinmapping>();
        }

        public int VehicleConfigurationId { get; set; }
        public int ShopMgtVehicleConfigId { get; set; }

        public ShopMgtVehicleConfig ShopMgtVehicleConfig { get; set; }
        public ICollection<AaiaidMapping> AaiaidMapping { get; set; }
        public ICollection<AcesidMapping> AcesidMapping { get; set; }
        public ICollection<Vinmapping> Vinmapping { get; set; }
    }
}
