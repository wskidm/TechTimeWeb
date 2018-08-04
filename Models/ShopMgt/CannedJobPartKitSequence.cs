using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class CannedJobPartKitSequence
    {
        public int CannedJobId { get; set; }
        public int? PartKitId { get; set; }
        public int Sequence { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public CannedJob CannedJob { get; set; }
        public PartKit PartKit { get; set; }
    }
}
