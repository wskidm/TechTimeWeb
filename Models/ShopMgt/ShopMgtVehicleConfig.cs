using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ShopMgtVehicleConfig
    {
        public ShopMgtVehicleConfig()
        {
            VehicleConfigurationMapping = new HashSet<VehicleConfigurationMapping>();
        }

        public int ShopMgtVehicleConfigId { get; set; }
        public int Year { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int SubModelId { get; set; }
        public int BodyStyleId { get; set; }
        public int EngineId { get; set; }
        public int BrakeId { get; set; }
        public int TransmissionId { get; set; }
        public int Gvwid { get; set; }
        public int DriveId { get; set; }

        public BodyStyle BodyStyle { get; set; }
        public Brake Brake { get; set; }
        public Drive Drive { get; set; }
        public Engine Engine { get; set; }
        public Gvw Gvw { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public SubModel SubModel { get; set; }
        public Transmission Transmission { get; set; }
        public Year YearNavigation { get; set; }
        public ICollection<VehicleConfigurationMapping> VehicleConfigurationMapping { get; set; }
    }
}
