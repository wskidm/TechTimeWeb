using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class RepairOrderTechs
    {
        public int RepairOrderTechsId { get; set; }
        public int? TechnicianId { get; set; }
        public int? RepairOrderId { get; set; }
        public int? TechRoleId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public RepairOrder RepairOrder { get; set; }
        public TechRole TechRole { get; set; }
        public Employee Technician { get; set; }
    }
}
