using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SyncUpQueue
    {
        public SyncUpQueue()
        {
            SyncQueue = new HashSet<SyncQueue>();
        }

        public int RecordId { get; set; }
        public DateTime RecordTs { get; set; }
        public string OperationType { get; set; }
        public string DataXml { get; set; }
        public int? BatchId { get; set; }

        public ICollection<SyncQueue> SyncQueue { get; set; }
    }
}
