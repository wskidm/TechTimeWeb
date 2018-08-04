using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Disclaimer
    {
        public int RoPhase { get; set; }
        public string Disclaimer1 { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrderPhase RoPhaseNavigation { get; set; }
    }
}
