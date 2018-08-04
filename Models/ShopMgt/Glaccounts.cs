using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Glaccounts
    {
        public int GlaccountId { get; set; }
        public int AccountClassId { get; set; }
        public string Glcode { get; set; }
        public string Description { get; set; }
        public int EntryTypeId { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public AccountClass AccountClass { get; set; }
        public GlentryTypes EntryType { get; set; }
    }
}
