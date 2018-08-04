using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class FollowupType
    {
        public FollowupType()
        {
            Followup = new HashSet<Followup>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Followup> Followup { get; set; }
    }
}
