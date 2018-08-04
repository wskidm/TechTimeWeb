using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderPhase
    {
        public RepairOrderPhase()
        {
            RepairOrder = new HashSet<RepairOrder>();
        }

        public int RepairOrderPhaseId { get; set; }
        public string Phase { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public Disclaimer Disclaimer { get; set; }
        public ICollection<RepairOrder> RepairOrder { get; set; }
    }
}
