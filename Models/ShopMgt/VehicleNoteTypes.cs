using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class VehicleNoteTypes
    {
        public VehicleNoteTypes()
        {
            VehicleNotes = new HashSet<VehicleNotes>();
        }

        public int VehicleNoteTypeId { get; set; }
        public string NoteLabel { get; set; }
        public int RecordVersion { get; set; }

        public ICollection<VehicleNotes> VehicleNotes { get; set; }
    }
}
