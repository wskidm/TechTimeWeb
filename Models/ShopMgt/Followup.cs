using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Followup
    {
        public int? FollowupType { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public int FollowupId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public FollowupType FollowupTypeNavigation { get; set; }
    }
}
