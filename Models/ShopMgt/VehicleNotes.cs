using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleNotes
    {
        public int VehicleNoteTypeId { get; set; }
        public int VehicleId { get; set; }
        public string NoteText { get; set; }
        public int RecordVersion { get; set; }

        public Vehicle Vehicle { get; set; }
        public VehicleNoteTypes VehicleNoteType { get; set; }
    }
}
