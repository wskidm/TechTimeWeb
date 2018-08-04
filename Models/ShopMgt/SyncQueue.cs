using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SyncQueue
    {
        public int SyncQueueId { get; set; }
        public int? SyncUpQueueId { get; set; }
        public int? SyncDownQueueId { get; set; }
        public int? BatchId { get; set; }

        public SyncUpBatch Batch { get; set; }
        public SyncDownQueue SyncDownQueue { get; set; }
        public SyncUpQueue SyncUpQueue { get; set; }
    }
}
