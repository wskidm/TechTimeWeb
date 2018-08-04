using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class TechRole
    {
        public TechRole()
        {
            RepairOrderTechs = new HashSet<RepairOrderTechs>();
        }

        public int TechRoleId { get; set; }
        public string Description { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<RepairOrderTechs> RepairOrderTechs { get; set; }
    }
}
