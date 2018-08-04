using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class UpdatesInstallStatus
    {
        public UpdatesInstallStatus()
        {
            UpdatesAvailable = new HashSet<UpdatesAvailable>();
        }

        public short InstallStatusId { get; set; }
        public string InstallStatusDescription { get; set; }

        public ICollection<UpdatesAvailable> UpdatesAvailable { get; set; }
    }
}
