using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class LaborRateDescription
    {
        public LaborRateDescription()
        {
            Customers = new HashSet<Customers>();
            LaborItem = new HashSet<LaborItem>();
            LaborRateVersion = new HashSet<LaborRateVersion>();
            RepairOrder = new HashSet<RepairOrder>();
            Vehicle = new HashSet<Vehicle>();
        }

        public int LaborRateDescriptionId { get; set; }
        public string Description { get; set; }
        public bool DefaultLaborRate { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Customers> Customers { get; set; }
        public ICollection<LaborItem> LaborItem { get; set; }
        public ICollection<LaborRateVersion> LaborRateVersion { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
