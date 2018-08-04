using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class NoteItem
    {
        public int NoteItemId { get; set; }
        public int LineItemId { get; set; }
        public string NoteText { get; set; }
        public bool PrintOnOrder { get; set; }
        public bool TechObservation { get; set; }
        public byte[] Timestamp { get; set; }
        public int RecordVersion { get; set; }

        public LineItem LineItem { get; set; }
    }
}
