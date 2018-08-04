using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class SyncDownQueue
    {
        public SyncDownQueue()
        {
            SyncQueue = new HashSet<SyncQueue>();
        }

        public int SyncDownQueueId { get; set; }
        public DateTime RecordTs { get; set; }
        public string DataXml { get; set; }
        public Guid? MessageId { get; set; }
        public int? MessageStatus { get; set; }

        public ICollection<SyncQueue> SyncQueue { get; set; }
    }
}
