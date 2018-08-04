using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SyncUpBatch
    {
        public SyncUpBatch()
        {
            SyncQueue = new HashSet<SyncQueue>();
        }

        public int BatchId { get; set; }
        public short BatchStatusId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastChangeDate { get; set; }

        public ICollection<SyncQueue> SyncQueue { get; set; }
    }
}
