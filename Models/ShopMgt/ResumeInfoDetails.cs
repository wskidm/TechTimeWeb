using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class ResumeInfoDetails
    {
        public int UpdatesAvailableId { get; set; }
        public int ComponentId { get; set; }
        public int Status { get; set; }

        public UpdatesAvailable UpdatesAvailable { get; set; }
    }
}
