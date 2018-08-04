using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class GlentryTypes
    {
        public GlentryTypes()
        {
            Glaccounts = new HashSet<Glaccounts>();
        }

        public int EntryTypeId { get; set; }
        public string EntryTypeDescription { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<Glaccounts> Glaccounts { get; set; }
    }
}
