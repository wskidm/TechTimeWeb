using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Groups
    {
        public Groups()
        {
            GroupAssociation = new HashSet<GroupAssociation>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<GroupAssociation> GroupAssociation { get; set; }
    }
}
