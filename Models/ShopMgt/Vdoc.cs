using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class Vdoc
    {
        public int LocalVdocId { get; set; }
        public int? LocalRepairOrderId { get; set; }
        public Guid GlobalVdocId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateLastOpened { get; set; }
        public DateTime DateLastSaved { get; set; }
        public string SectionCvd { get; set; }
        public string SectionTrace { get; set; }
        public string SectionGeneric { get; set; }
        public string SectionTechview { get; set; }
        public string SectionPcodes { get; set; }
        public byte[] Timestamp { get; set; }

        public RepairOrder LocalRepairOrder { get; set; }
    }
}
