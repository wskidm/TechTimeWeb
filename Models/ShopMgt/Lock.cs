using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Lock
    {
        public int LockId { get; set; }
        public int? RepairOrderId { get; set; }
        public int? OrderRevisionId { get; set; }
        public string ComputerName { get; set; }
        public DateTime CreateDate { get; set; }
        public int RecordVersion { get; set; }
    }
}
