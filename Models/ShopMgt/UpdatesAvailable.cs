using System;
using System.Collections.Generic;

namespace TechTime.Models.ShopMgt
{
    public partial class UpdatesAvailable
    {
        public UpdatesAvailable()
        {
            ResumeInfoDetails = new HashSet<ResumeInfoDetails>();
        }

        public int UpdatesAvailableId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public short InstallationStatus { get; set; }
        public string Version { get; set; }
        public DateTime InstallationDate { get; set; }
        public long FileCrc { get; set; }
        public long Size { get; set; }
        public string Dependency { get; set; }
        public int? InstallationRetries { get; set; }
        public string PreviousVersion { get; set; }
        public string Description { get; set; }
        public short? ReportStatus { get; set; }

        public UpdatesInstallStatus InstallationStatusNavigation { get; set; }
        public ICollection<ResumeInfoDetails> ResumeInfoDetails { get; set; }
    }
}
