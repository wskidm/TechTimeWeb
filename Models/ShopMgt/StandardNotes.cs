using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class StandardNotes
    {
        public int StandardNotesId { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }
    }
}
